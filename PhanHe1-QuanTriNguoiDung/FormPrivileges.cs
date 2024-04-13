using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormPrivileges : Form
    {
        public FormPrivileges()
        {
            InitializeComponent();
            
        }
        // query mặc định
        private string query = "SELECT t.* FROM DBA_TAB_PRIVS t WHERE t.GRANTEE ";
        private string condition = " IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN')";

        private void FormPrivileges_Load(object sender, EventArgs e)
        {
            string selectAllPrivilegesQuery = query + condition;
            
            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            userGridView.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Nut table name
            query = "SELECT t.* FROM DBA_TAB_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            userGridView.DataSource = dataTable;
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            query = "SELECT t.* FROM DBA_COL_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            userGridView.DataSource = dataTable;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            condition = " IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN')";
            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            userGridView.DataSource = dataTable;
        }

        private void buttonRole_Click(object sender, EventArgs e)
        {
            condition = " IN (SELECT ROLE FROM DBA_ROLES)";
            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            userGridView.DataSource = dataTable;
        }
    }
}
