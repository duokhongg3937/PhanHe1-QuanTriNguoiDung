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
