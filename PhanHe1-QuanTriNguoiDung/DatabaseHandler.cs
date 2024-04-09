using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace PhanHe1_QuanTriNguoiDung
{
    public static class DatabaseHandler
    {
        private static string _connectionString = "";
        private static OracleConnection _connection; 

        //public static DataTable executeQuery(string query)
        //{

        //}

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
            if (_connection != null && _connection.State != ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
