using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public static class DatabaseHandler
    {
        private static string _connectionString = "";
        private static OracleConnection _connection;

        public static DataTable ExecuteQuery(string query)
        {
            DataTable result = new DataTable();

            try
            {
                if (IsConnected())
                {
                    OracleCommand cmd = new OracleCommand(query, _connection);
                    OracleDataReader reader = cmd.ExecuteReader();
                    result.Load(reader);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Truy vấn lỗi: " + ex.Message);
            }

            return result;
        }

        public static int ExecuteNonQuery(string nonQueryStr)
        {
            try
            {
                if (IsConnected())
                {
                    OracleCommand cmd = new OracleCommand(nonQueryStr, _connection);
                    return cmd.ExecuteNonQuery();
                } else
                {
                    return -1;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Truy vấn lỗi: " + ex.Message);
                return -1;
            }
        }

        public static bool Connect(string username, string password)
        {
            OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder
            {
                DataSource = "localhost",
                UserID = username.Trim(),
                Password = password.Trim()
            };

            _connectionString = builder.ToString();

            try
            {
                _connection = new OracleConnection(_connectionString);
                _connection.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddNewUser(string username, string password)
        {
            if (!IsConnected() || string.IsNullOrEmpty(username))
            {
                return false;
            }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"create user {username} ";
            if (!string.IsNullOrEmpty(password))
            {
                str += $"identified by \"{password}\"";
            }
            ExecuteNonQuery(str);

            str = $"grant connect to {username}";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool DropUser(string username)
        {
            if (!IsConnected() || string.IsNullOrEmpty(username))
            {
                return false;
            }

            if (!IsUserExists(username)) { return false; }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"drop user {username} cascade";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool IsUserExists(string username)
        {
            DataTable users = ExecuteQuery($"select * from DBA_USERS where USERNAME = '{username}' ");
            return users.Rows.Count > 0;
        }

        public static void Disconnect()
        {
            if (IsConnected())
            {
                _connection.Close();
            }
        }

        public static bool IsConnected()
        {
            if (_connection != null)
            {
                return _connection.State == ConnectionState.Open;
            }
            return false;
        }
    }
}
