using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
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

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool AddNewRole(string rolename, string password)
        {
            if (!IsConnected() || string.IsNullOrEmpty(rolename))
            {
                return false;
            }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"create role {rolename} ";
            if (!string.IsNullOrEmpty(password))
            {
                str += $"identified by \"{password}\"";
            }
            ExecuteNonQuery(str);

            //str = $"grant connect to {rolename}";
            //ExecuteNonQuery(str);

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
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

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool UpdateUser(string username, string password)
        {
            if (!IsConnected() || string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (!IsUserExists(username)) { return false; }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"alter user {username} identified by {password}";
            ExecuteNonQuery(str);

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
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

        public static DataTable GetAllUsers()
        {
            string selectAllUsersQuery = "select USERNAME, USER_ID, EXPIRY_DATE, CREATED, PROFILE  " +
                "from DBA_USERS where ACCOUNT_STATUS = 'OPEN'";

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllUsersQuery);

            return dataTable;
        }

        public static DataTable GetAllRoles()
        {
            string selectAllRolesQuery = "SELECT * FROM DBA_ROLES";

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllRolesQuery);

            return dataTable;
        }
    }
}
