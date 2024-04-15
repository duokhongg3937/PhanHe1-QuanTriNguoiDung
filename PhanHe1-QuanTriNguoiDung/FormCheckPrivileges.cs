using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormCheckPrivileges : Form
    {
        public FormCheckPrivileges()
        {
            InitializeComponent();
        }


        public BindingList<String> listUsers;
        public BindingList<String> listTypes;
        public string currentType;

        private void userComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_selectionChanged(object sender, EventArgs e)
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
            string username = (string)userComboBox.SelectedValue;
            string type = (string)comboBox1.SelectedValue;

            DataTable dataTable = null;

            if (type ==  "--Select--" || username == "--Select--")
            {
                dataTable = null;
            }
            else
            {
                if (type == "ROLE")
                {
                    currentType = "ROLE";
                    dataTable = DatabaseHandler.GetRolePrivileges(username);
                }
                else if (type == "SYSTEM")
                {
                    currentType = "SYSTEM";
                    dataTable = DatabaseHandler.GetSysPrivileges(username);
                }
                else if (type == "TABLE")
                {
                    currentType = "TABLE";
                    dataTable = DatabaseHandler.GetTablePrivileges(username);
                }
                else
                {
                    currentType = "COL";
                    dataTable = DatabaseHandler.GetColPrivileges(username);
                }
            }
            checkGridView.DataSource = dataTable;
        }

        private void FormGrantPermissions_Load(object sender, EventArgs e)
        {
            #region get data for combo box
            // all users for combo box

            listUsers = new BindingList<String>(DatabaseHandler.getListUsers_Roles());
            userComboBox.DataSource = listUsers;
            listUsers.Add("--Select--");
            userComboBox.SelectedIndex = listUsers.Count - 1;

            // all types for combo box

            listTypes = new BindingList<String>(DatabaseHandler.getTypes());
            comboBox1.DataSource = listTypes;
            listTypes.Add("--Select--");
            comboBox1.SelectedIndex = listTypes.Count - 1;

            #endregion
        }
        private void userComboBox_DropDownOpened(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown mở
            userComboBox.ForeColor = Color.Blue;
        }

        private void userComboBox_DropDownClosed(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown đóng
            userComboBox.ForeColor = Color.BlueViolet;
        }

        private void comboBox1_DropDownOpened(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown mở
            comboBox1.ForeColor = Color.Blue;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi dropdown đóng
            comboBox1.ForeColor = Color.BlueViolet;
        }

        private void revokePrivBtn_clicked(object sender, EventArgs e)
        {
            if (checkGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng quyền bất kỳ để thu hồi");
                return;
            }
            else if (checkGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
            {
                DataRow selectedRow = selectedDataRowView.Row;
                string user = (string)selectedRow["GRANTEE"];


                switch (currentType)
                {

                    case "ROLE":
                        string role = (string)selectedRow["GRANTED_ROLE"];

                        string query = $"REVOKE {role} FROM {user} ";

                        DialogResult res = MessageBox.Show($" Bạn có chắc chắn muốn thu hồi quyền {role} từ {user}?",
                                "Xác nhận thu hồi quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            if (DatabaseHandler.RevokePrivilege(user, query))
                            {
                                MessageBox.Show($"Đã thu hồi quyền thành công!", "Thu hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkGridView != null)
                                {

                                    
                                      DataTable  dataTable = DatabaseHandler.GetRolePrivileges(user);
                                   

                                    checkGridView.DataSource = dataTable;
                                }

                            }
                        }

                        break;

                    case "SYSTEM":
                        string priv = (string)selectedRow["PRIVILEGE"];
                        query = $"REVOKE {priv} FROM {user} ";

                        res = MessageBox.Show($" Bạn có chắc chắn muốn thu hồi quyền {priv} từ {user}?",
                                "Xác nhận thu hồi quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            if (DatabaseHandler.RevokePrivilege(user, query))
                            {
                                MessageBox.Show($"Đã thu hồi quyền thành công!", "Thu hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkGridView != null)
                                {

                                    
                                   
                                    DataTable    dataTable = DatabaseHandler.GetSysPrivileges(user);
                                    

                                    checkGridView.DataSource = dataTable;
                                }

                            }
                        }

                        break;

                    case "TABLE":
                        string table = (string)selectedRow["TABLE_NAME"];
                        string owner = (string)selectedRow["OWNER"];
                        priv = (string)selectedRow["PRIVILEGE"];

                        query = $"REVOKE {priv} ON {owner + '.' + table} FROM {user} ";

                        res = MessageBox.Show($" Bạn có chắc chắn muốn thu hồi quyền {priv} trên {owner + '.' + table} từ {user}?",
                                "Xác nhận thu hồi quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            if (DatabaseHandler.RevokePrivilege(user, query))
                            {
                                MessageBox.Show($"Đã thu hồi quyền thành công!", "Thu hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkGridView != null)
                                {

                                    DataTable dataTable = DatabaseHandler.GetTablePrivileges(user);


                                    checkGridView.DataSource = dataTable;
                                }

                            }
                        }
                        break;

                    case "COL":
                        string col = (string)selectedRow["COLUMN_NAME"];
                        table = (string)selectedRow["TABLE_NAME"];
                        owner = (string)selectedRow["OWNER"];
                        priv = (string)selectedRow["PRIVILEGE"];

                        query = $"REVOKE {priv} ON {owner + '.' + table} FROM {user} ";

                        res = MessageBox.Show($" Bạn có chắc chắn muốn thu hồi quyền {priv} trên bảng {owner + '.' + table} từ {user}?",
                                "Xác nhận thu hồi quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            if (DatabaseHandler.RevokePrivilege(user, query))
                            {
                                MessageBox.Show($"Đã thu hồi quyền thành công!", "Thu hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkGridView != null)
                                {

                                    DataTable dataTable = DatabaseHandler.GetColPrivileges(user);


                                    checkGridView.DataSource = dataTable;
                                }

                            }
                        }
                        break;
                }

            }
            }

        private void cellContentPriv_clicked(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
