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

            #region get data for combo box
            // all users for combo box

            listUsers = new BindingList<string>(DatabaseHandler.getListUsers());
            userComboBox.DataSource = listUsers;


            // all system privileges
            listSystemPrivs = new BindingList<string>(DatabaseHandler.getSystemPrivs());
            sysPrivComboBox.DataSource = listSystemPrivs;

            // all object privileges
            listObjectPrivs = new BindingList<string>(DatabaseHandler.getObjectPrivs());
            objPrivComboBox.DataSource = listObjectPrivs;


            // all tables
            listTables = new BindingList<string>(DatabaseHandler.getTables());
            tablePrivComboBox.DataSource = listTables;


            // all roles
            listRoles = new BindingList<string>(DatabaseHandler.getRoles());
            rolePrivComboBox.DataSource = listRoles;

            #endregion
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

        public BindingList<String> listUsers;
        public BindingList<String> listSystemPrivs;
        public BindingList<String> listObjectPrivs;
        public BindingList<string> listTables;
        public BindingList<String> listRoles;


 

        private void userComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void sysPrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void objPrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void tablePrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void rolePrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void colTablePrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void colColPrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void selectCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirmGrantBtn_clicked(object sender, EventArgs e)
        {

        }

        private void withGrantOptCheckBox_checkedChanged(object sender, EventArgs e)
        {

        }

        private void userComboBox_DropDownOpened(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown mở
            userComboBox.ForeColor = Color.Red;
        }

        private void userComboBox_DropDownClosed(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown đóng
            userComboBox.ForeColor = Color.Red;
        }
    }
}
