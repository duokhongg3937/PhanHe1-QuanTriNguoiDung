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
        private string query = "SELECT GRANTEE,OWNER,TABLE_NAME,PRIVILEGE,TYPE FROM DBA_TAB_PRIVS t WHERE t.GRANTEE ";
        private string condition = " IN (SELECT USERNAME FROM DBA_USERS)";

        private void FormPrivileges_Load(object sender, EventArgs e)
        {
            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Nut table/view name
            query = "SELECT GRANTEE,OWNER,TABLE_NAME,PRIVILEGE,TYPE FROM DBA_TAB_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            query = "SELECT GRANTEE,OWNER,TABLE_NAME,COLUMN_NAME,PRIVILEGE FROM DBA_COL_PRIVS t WHERE t.GRANTEE ";

            string selectAllPrivilegesQuery = query + condition;

            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllPrivilegesQuery);
            privsGridView.DataSource = dataTable;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            condition = " IN (SELECT USERNAME FROM DBA_USERS)";
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
            if (privsGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng quyền bất kỳ để thu hồi");
                return;
            }
            else if (privsGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
            {
                DataRow selectedRow = selectedDataRowView.Row;
                string user = (string)selectedRow["GRANTEE"];
                string priv = (string)selectedRow["PRIVILEGE"];
                string owner = (string)selectedRow["OWNER"];
                string table = (string)selectedRow["TABLE_NAME"];

                string fullTableName = owner + "." + table;
                

                DialogResult res = MessageBox.Show($" Bạn có chắc chắn muốn thu hồi quyền {priv} trên table {fullTableName} từ {user}?",
                        "Xác nhận thu hồi quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (DatabaseHandler.RevokePrivilege(user, priv, fullTableName))
                    {
                        MessageBox.Show($"Đã thu hồi quyền thành công!", "Thu hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (privsGridView != null)
                        {
                            string selectAllPrivilegesQuery = query + condition;

                            DataTable dataTable = DatabaseHandler
                                .ExecuteQuery(selectAllPrivilegesQuery);
                            privsGridView.DataSource = dataTable;
                        }

                    }
                }
            }
        }

        private void privCell_clicked(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

