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
    public partial class FormGrantPermissions : Form
    {
        public FormGrantPermissions()
        {
            InitializeComponent();
        }

        public BindingList<String> listUsers;
        public BindingList<String> listSystemPrivs;
        public BindingList<String> listObjectPrivs;
        public BindingList<String> listTables;
        public BindingList<String> listRoles;

        public BindingList<String> listCols;




        #region all selection changed events
        private void userComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void sysPrivComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void objPrivComboBox_selectionChanged(object sender, EventArgs e)
        {
            string privName = objPrivComboBox.SelectedItem.ToString();
            if (tablePrivComboBox.SelectedItem == null) return;
            string tableName = tablePrivComboBox.SelectedItem.ToString();

            if ((privName != "SELECT" || privName == "UPDATE") && tableName != "--Select--" )
            {
                // get all col name of that table
                listCols = new BindingList<string>(DatabaseHandler.getColsOfTable(tableName));
                listCols.Insert(0, "--Select--");
                colColPrivComboBox.SelectedIndex = 0;

            } else
            {
                listCols = new BindingList<string>();
            }

            colColPrivComboBox.DataSource = listCols;


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
        #endregion

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

        #region all tasks need to do when load this form
        private void FormGrantPermissions_Load(object sender, EventArgs e)
        {
            #region get data for combo box
            // all users for combo box

            listUsers = new BindingList<String>(DatabaseHandler.getListUsers());
            userComboBox.DataSource = listUsers;
            listUsers.Insert(0, "--Select--");
            userComboBox.SelectedIndex = 0;


            // all system privileges
            listSystemPrivs = new BindingList<string>(DatabaseHandler.getSystemPrivs());
            sysPrivComboBox.DataSource = listSystemPrivs;
            listSystemPrivs.Insert(0, "--Select--");
            sysPrivComboBox.SelectedIndex = 0;

            // all object privileges
            listObjectPrivs = new BindingList<string>(DatabaseHandler.getObjectPrivs());
            objPrivComboBox.DataSource = listObjectPrivs;
            listObjectPrivs.Insert(0, "--Select--");
            objPrivComboBox.SelectedIndex = 0;


            // all tables
            listTables = new BindingList<string>(DatabaseHandler.getTables());
            tablePrivComboBox.DataSource = listTables;
            listTables.Insert(0, "--Select--");
            tablePrivComboBox.SelectedIndex = 0;


            // all roles
            listRoles = new BindingList<string>(DatabaseHandler.getRoles());
            rolePrivComboBox.DataSource = listRoles;
            listRoles.Insert(0, "--Select--");
            rolePrivComboBox.SelectedIndex = 0;

            // cols
            //colColPrivComboBox.DataSource = listCols;


            #endregion
        }
        #endregion

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
    }
}
