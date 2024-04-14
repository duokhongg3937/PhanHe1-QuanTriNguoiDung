using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public static class DatabaseHandler
    {
        private static string _connectionString = "";
        private static OracleConnection _connection;
        private static string currentUsername = "";

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
            currentUsername = username;

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

        #region all queries for grant permissions | form privileges
        public static List<string> getListUsers()
        {
            string query = "select USERNAME  " +
                                        "from DBA_USERS where ACCOUNT_STATUS = 'OPEN'";

            List<string> users = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string userName = reader.GetString(0); 
                                users.Add(userName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            // Trả về danh sách người dùng
            return users;
        }

        public static List<string> getSystemPrivs()
        {
            string query = "select privilege from dba_sys_privs where grantee = 'DBA'";
            Debug.WriteLine(query);

            List<string> privs = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        //cmd.Parameters.Add(new OracleParameter("@grantee", OracleDbType.Varchar2)).Value = "DBA";
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string priv = reader["privilege"].ToString();
                                privs.Add(priv);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            // Trả về danh sách người dùng
            return privs;
        }

        public static List<string> getObjectPrivs()
        {
            string query = "select privilege from dba_tab_privs where grantee = 'DBA'";

            List<string> privs = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        //cmd.Parameters.Add(new OracleParameter("@grantee", OracleDbType.Varchar2)).Value = "DBA";

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string priv = reader.GetString(0);
                                privs.Add(priv);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            // Trả về danh sách người dùng
            return privs;
        }

        public static List<string> getTables()
        {
            string query = "select TABLE_NAME from DBA_TABLES";

            List<string> tables = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string table = reader.GetString(0);
                                tables.Add(table);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            // Trả về danh sách người dùng
            return tables;
        }

        public static List<string> getRoles()
        {
            string query = "select ROLE from DBA_ROLES";

            List<string> roles = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string role = reader.GetString(0);
                                roles.Add(role);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            // Trả về danh sách người dùng
            return roles;
        }

        #endregion
    }
}
