using System;
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

            if (type == "ROLE")
            {
                dataTable = DatabaseHandler.GetRolePrivileges(username);
            }
            else if (type == "SYSTEM")
            {
                dataTable = DatabaseHandler.GetSysPrivileges(username);
            }
            else
            {
                dataTable = DatabaseHandler.GetTablePrivileges(username);
            }


            checkGridView.DataSource = dataTable;
        }

        private void FormGrantPermissions_Load(object sender, EventArgs e)
        {
            #region get data for combo box
            // all users for combo box

            listUsers = new BindingList<String>(DatabaseHandler.getListUsers());
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
    }
}
