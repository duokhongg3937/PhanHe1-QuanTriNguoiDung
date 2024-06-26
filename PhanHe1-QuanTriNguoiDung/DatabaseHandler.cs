﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public static class DatabaseHandler
    {
        private static string _connectionString = "";
        private static OracleConnection _connection;
        public static string currentUsername = "";

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

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool AddNewRole(string rolename)
        {
            if (!IsConnected() || string.IsNullOrEmpty(rolename))
            {
                return false;
            }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"create role {rolename} ";
            ExecuteNonQuery(str);

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

        public static bool IsRoleExists(string roleName)
        {
            DataTable roles = ExecuteQuery($"select ROLE from DBA_ROLES where ROLE = '{roleName}'");
            return roles.Rows.Count > 0;
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
        public static List<string> getListUsers_Roles()
        {
            string query = @"select * from 
                            (select USERNAME from DBA_USERS where username <> :currentUser and DEFAULT_TABLESPACE = 'USERS' and ACCOUNT_STATUS = 'OPEN')
                            union
                            (select ROLE as USERNAME from DBA_ROLES)
                            ";

            List<string> users = new List<string>();

            try
            {
                // Kiểm tra kết nối
                if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        // Thêm tham số `@username` với giá trị của người dùng hiện tại.
                        cmd.Parameters.Add(new OracleParameter(":currentUser", OracleDbType.Varchar2)).Value = currentUsername.ToUpper();

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
            string query = "select distinct privilege from dba_sys_privs where grantee = 'DBA'";
            Debug.WriteLine(query);

            List<string> privs = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        //cmd.Parameters.Add(new OracleParameter("@username", OracleDbType.Varchar2)).Value = currentUsername.ToUpper();
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
            string query = "select distinct privilege from dba_tab_privs where grantee = 'DBA'";

            List<string> privs = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
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

        public static List<string> getTables(string priv)
        {
            //string query = "select distinct table_name from dba_tab_privs where owner = :username or (grantee = 'DBA' and grantable = 'YES')";
            string query = @"
                                select distinct table_name from
(
SELECT DISTINCT owner || '.' || table_name as table_name
FROM dba_tab_privs
WHERE grantee = 'DBA' 
    AND privilege IN (:priv) AND GRANTABLE = 'YES'

UNION

SELECT OWNER || '.' || TABLE_NAME as table_name from DBA_TABLES where owner IN (
    (select USERNAME from DBA_USERS where DEFAULT_TABLESPACE = 'USERS' and ACCOUNT_STATUS = 'OPEN')
                           
)

UNION 

select distinct (OWNER || '.' || VIEW_NAME) as table_name from DBA_VIEWS WHERE OWNER <> 'SYS'
)
                        
                            ";

            List<string> tables = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        // Thêm tham số `@username` với giá trị của người dùng hiện tại.
                        cmd.Parameters.Add(new OracleParameter(":priv", OracleDbType.Varchar2)).Value = priv.ToUpper();

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string table = reader["table_name"].ToString();
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

        public static List<string> getColsOfTable(string tableFullName)
        {
            string owner, table;
            // Tách chuỗi thành mảng chuỗi sử dụng dấu chấm làm ký tự phân cách
            string[] parts = tableFullName.Split('.');

            
                // Gán hai phần tử vào các biến owner và table
                owner = parts[0];
                table = parts[1];


            List<string> cols = new List<string>();
            string query = @"
                        SELECT COLUMN_NAME
                        FROM all_tab_columns 
                        WHERE OWNER = :val1 AND TABLE_NAME = :val2 ";


            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                        cmd.Parameters.Add(new OracleParameter(":val1", OracleDbType.Varchar2)).Value = owner.ToUpper();
                        cmd.Parameters.Add(new OracleParameter(":val2", OracleDbType.Varchar2)).Value = table.ToUpper();

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string col = reader[0].ToString();
                                cols.Add(col);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi nhận lỗi hoặc xử lý theo cách khác
                Console.WriteLine("Truy vấn lỗi: " + ex.Message + owner + table);
                // Bạn có thể xử lý thêm lỗi hoặc ghi nhật ký lỗi nếu cần thiết
            }

            return cols;
        }

        public static List<string> getRoles()
        {
            string query = "select distinct ROLE from DBA_ROLES";

            List<string> roles = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
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

        public static List<String> getViews()
        {
            string query = "select distinct (OWNER || '.' || VIEW_NAME) from DBA_VIEWS WHERE OWNER <> 'SYS'";


            List<string> views = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string v = reader[0].ToString();
                                views.Add(v);
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
            return views;
        }

        public static List<String> getFuncs()
        {
            string query = "select distinct (OWNER || '.' || OBJECT_NAME) from DBA_PROCEDURES WHERE OBJECT_TYPE = 'FUNCTION' AND OWNER <> 'SYS' AND OWNER <> 'XDB'";

            List<string> funcs = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string func = reader[0].ToString();
                                funcs.Add(func);
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
            return funcs;
        }

        public static List<String> getSPs()
        {
            string query = "select distinct (OWNER || '.' || OBJECT_NAME) from DBA_PROCEDURES WHERE OBJECT_TYPE = 'PROCEDURE' AND OWNER <> 'SYS' AND OWNER <> 'XDB'";



            List<string> sps = new List<string>();

            try
            {
                // Kiểm tra kết nối
                //if (IsConnected())
                {
                    // Sử dụng từ khóa using để quản lý tài nguyên của OracleCommand và OracleDataReader
                    using (OracleCommand cmd = new OracleCommand(query, _connection))
                    {
                  

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Đọc dữ liệu và thêm vào danh sách
                            while (reader.Read())
                            {
                                string sp = reader[0].ToString();
                                sps.Add(sp);
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
            return sps;
        }

        public static bool GrantPerm(string query)
        {
            if (!IsConnected())
            {
                return false;
            }


            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            try
            {
                OracleCommand cmd = new OracleCommand(query, _connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Truy vấn lỗi: " + ex.Message);
                return false;
            }

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        public static bool RevokePrivilege(string user, string query)
        {
            if (!IsConnected())
            {
                return false;
            }


            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            try
            {
                    OracleCommand cmd = new OracleCommand(query, _connection);
                     cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Truy vấn lỗi: " + ex.Message);
                return false;
            }

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        #endregion

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
            string selectAllRolesQuery = "select ROLE, ROLE_ID, PASSWORD_REQUIRED from DBA_ROLES";

            DataTable dataTable = ExecuteQuery(selectAllRolesQuery);

            return dataTable;
        }

        public static DataTable GetSysPrivileges(string username)
        {
            string selectQuery = $"select * from dba_sys_privs where grantee = '{username}'";

            DataTable dataTable = ExecuteQuery(selectQuery);

            return dataTable;
        }

        public static DataTable GetRolePrivileges(string username)
        {
            string selectQuery = $"select * from dba_role_privs where grantee = '{username}'";

            DataTable dataTable = ExecuteQuery(selectQuery);

            return dataTable;
        }

        public static DataTable GetTablePrivileges(string username)
        {
            string selectQuery = $"select * from dba_tab_privs where grantee = '{username}'";

            DataTable dataTable = ExecuteQuery(selectQuery);

            return dataTable;
        }

        public static DataTable GetColPrivileges(string username)
        {
            string selectQuery = $"select * from dba_col_privs where grantee = '{username}'";

            DataTable dataTable = ExecuteQuery(selectQuery);

            return dataTable;
        }

        public static bool DropRole(string roleName)
        {
            if (!IsConnected() || string.IsNullOrEmpty(roleName))
            {
                return false;
            }

            if (!IsRoleExists(roleName)) { return false; }

            string str = $"alter session set \"_ORACLE_SCRIPT\" = true";
            ExecuteNonQuery(str);

            str = $"drop role {roleName}";
            ExecuteNonQuery(str);

            str = $"alter session set \"_ORACLE_SCRIPT\" = false";
            ExecuteNonQuery(str);

            return true;
        }

        public static List<string> getTypes()
        {
            List<string> types = new List<string>();
            types.Add("ROLE");
            types.Add("SYSTEM");
            types.Add("TABLE");
            types.Add("COLUMN");
            return types;
        }
    }
}
