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
            privsGridView.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Nut table name
            query = "SELECT t.* FROM DBA_TAB_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            query = "SELECT t.* FROM DBA_COL_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            condition = " IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN')";
            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void buttonRole_Click(object sender, EventArgs e)
        {
            condition = " IN (SELECT ROLE FROM DBA_ROLES)";
            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void revokePermBtn_clicked(object sender, EventArgs e)
        {
            //if (privsGridView.SelectedRows.Count <= 0)
            //{
            //    MessageBox.Show("Vui lòng chọn 1 dòng quyền bất kỳ để xóa");
            //    return;
            //}
            //else if (privsGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
            //{
            //    DataRow selectedRow = selectedDataRowView.Row;
            //    string username = (string)selectedRow["USERNAME"];

            //    DialogResult res = MessageBox.Show($"Bạn đã chọn user: {username} \n\n\n Bạn có chắc chắn muốn xóa user này?",
            //            "Xác nhận xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (res == DialogResult.Yes)
            //    {
            //        if (DatabaseHandler.DropUser(username))
            //        {
            //            MessageBox.Show($"Thành công xóa user {username}", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Helper.reloadUserTable(privsGridView);
            //        }
            //    }
            //}
        }

        private void privCell_clicked(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

