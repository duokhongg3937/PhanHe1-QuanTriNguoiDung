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
        public BindingList<String> listFuncs;
        public BindingList<String> listSPs;
        public BindingList<String> listViews;




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


            // all tables
            if (listTables == null)
            {
                listTables = new BindingList<string>(DatabaseHandler.getTables(privName));
                tablePrivComboBox.DataSource = listTables;
                listTables.Insert(0, "--Select--");
                tablePrivComboBox.SelectedIndex = 0;
            }


            if ((privName == "SELECT" || privName == "UPDATE"))
            {
                if (tablePrivComboBox != null && tablePrivComboBox.SelectedItem != null && tablePrivComboBox.SelectedItem.ToString() != "--Select--")
                {
                    string tableName = tablePrivComboBox.SelectedItem.ToString();
                    // get all col name of that table
                    listCols = new BindingList<string>(DatabaseHandler.getColsOfTable(tableName));
                    listCols.Insert(0, "--Select--");

                    colColPrivComboBox.DataSource = listCols;
                    colColPrivComboBox.SelectedIndex = 0;

                }

            }

        }

        private void tablePrivComboBox_selectionChanged(object sender, EventArgs e)
        {
            string privName = objPrivComboBox.SelectedItem.ToString();


            if ((privName == "SELECT" || privName == "UPDATE"))
            {
                if (tablePrivComboBox != null && tablePrivComboBox.SelectedItem != null && tablePrivComboBox.SelectedItem.ToString() != "--Select--")
                {
                    string tableName = tablePrivComboBox.SelectedItem.ToString();
                    // get all col name of that table
                    listCols = new BindingList<string>(DatabaseHandler.getColsOfTable(tableName));
                    listCols.Insert(0, "--Select--");

                    colColPrivComboBox.DataSource = listCols;
                    colColPrivComboBox.SelectedIndex = 0;

                }

            }
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

  

        private void confirmGrantBtn_clicked(object sender, EventArgs e)
        {
            string user = userComboBox.SelectedItem.ToString();
            bool withGrantOpt = withGrantOptCheckBox.Checked;

            string sysPriv = sysPrivComboBox.SelectedItem.ToString();
            string role = rolePrivComboBox.SelectedItem.ToString();

            string objPriv = objPrivComboBox.SelectedItem.ToString();
            string table = tablePrivComboBox.SelectedItem.ToString();

            string func = funcComboBox.SelectedItem.ToString();
            string sp = procedureComboBox.SelectedItem.ToString();



            // check if user has been chosen or not
            if (user == "--Select--")
            {
                MessageBox.Show("Vui lòng chọn user muốn cấp quyền!!!");
                return;
            }

            // if not choose any permission type
            if (sysPriv != "--Select--" || role != "--Select--" || objPriv != "--Select--" || sp != "--Select--" || func != "--Select--")
            { } 
            else
            {
                MessageBox.Show("Vui lòng chọn quyền muốn cấp!!!");
                return;
            }
            bool res = true;

            // grant perm


            if (objPriv != "--Select--")
            {
                if (table == "--Select--")
                {
                    MessageBox.Show("Vui lòng chọn Table!!!");
                    return;
                }



                string query = "";

                if ( objPriv == "UPDATE" || objPriv == "SELECT")
                {
                    
                    if (colColPrivComboBox.SelectedItem == null || colColPrivComboBox.SelectedItem.ToString() == "--Select--")
                    {
                        MessageBox.Show($"Vui lòng chọn cột cho quyền {objPriv}!!!");
                        return;
                    }

                    string col = colColPrivComboBox.SelectedItem.ToString();
                    if (objPriv == "UPDATE")
                    {
                        query = $"GRANT {objPriv} ({col}) ON {table} TO {user} ";
                    } else
                    {
                        query = $"CREATE OR REPLACE VIEW {table}_VIEW_{col.ToUpper()} AS SELECT {col} FROM {table}";
                        res = DatabaseHandler.GrantPerm(query);
                         query = $"GRANT SELECT ON {table}_VIEW_{col.ToUpper()} TO {user} ";
                    }
                    
                    if (withGrantOpt)
                    {
                        query += "WITH GRANT OPTION";
                    }
                    res = DatabaseHandler.GrantPerm(query);

                } else
                {
                    query = $"GRANT {objPriv} on {table} TO {user} ";
                }
                if (withGrantOpt)
                {
                    query += "WITH GRANT OPTION";
                }
                res = DatabaseHandler.GrantPerm(query);

            }

            if (sysPriv != "--Select--")
            {
                string query = $"GRANT {sysPriv} TO {user} ";
                if (withGrantOpt)
                {
                    query += "WITH ADMIN OPTION";
                }
                res = DatabaseHandler.GrantPerm(query);
                
            }

            if (role != "--Select--")
            {
                string query = $"GRANT {role} TO {user} ";
                if (withGrantOpt)
                {
                    query += "WITH GRANT OPTION";
                }
                res = DatabaseHandler.GrantPerm(query);
            }

            if (func != "--Select--")
            {
                string query = $"GRANT EXECUTE ON {func} TO {user} ";
                if (withGrantOpt)
                {
                    query += "WITH GRANT OPTION";
                }
                res = DatabaseHandler.GrantPerm(query);

            }

            if (sp != "--Select--")
            {
                string query = $"GRANT EXECUTE ON {sp} TO {user} ";
                if (withGrantOpt)
                {
                    query += "WITH GRANT OPTION";
                }
                res = DatabaseHandler.GrantPerm(query);

            }

            if (res)
            {
                MessageBox.Show("Đã cấp quyền thành công!");
            }


        }

        private void withGrantOptCheckBox_checkedChanged(object sender, EventArgs e)
        {

        }

        #region all tasks need to do when load this form
        private void FormGrantPermissions_Load(object sender, EventArgs e)
        {
            #region get data for combo box
            // all users for combo box

            listUsers = new BindingList<String>(DatabaseHandler.getListUsers_Roles());
            userComboBox.DataSource = listUsers;
            listUsers.Insert(0, "--Select--");
            userComboBox.SelectedIndex = 0;


            // all system privileges
            listSystemPrivs = new BindingList<string>(DatabaseHandler.getSystemPrivs());
            sysPrivComboBox.DataSource = listSystemPrivs;
            listSystemPrivs.Insert(0, "--Select--");
            sysPrivComboBox.SelectedIndex = 0;

            // all object privileges
            // ... this for all objects: table, view, sp, func,...
            //listObjectPrivs = new BindingList<string>(DatabaseHandler.getObjectPrivs());

            // this just manipulate in table: 
            listObjectPrivs = new BindingList<string>();
            listObjectPrivs.Add("SELECT");
            listObjectPrivs.Add("UPDATE");
            listObjectPrivs.Add("INSERT");
            listObjectPrivs.Add("DELETE");

            objPrivComboBox.DataSource = listObjectPrivs;
            listObjectPrivs.Insert(0, "--Select--");
            objPrivComboBox.SelectedIndex = 0;




            // all roles
            listRoles = new BindingList<string>(DatabaseHandler.getRoles());
            rolePrivComboBox.DataSource = listRoles;
            listRoles.Insert(0, "--Select--");
            rolePrivComboBox.SelectedIndex = 0;

            // sps and funcs
            listFuncs = new BindingList<string>(DatabaseHandler.getFuncs());
            listFuncs.Insert(0, "--Select--");
            funcComboBox.DataSource = listFuncs;
            funcComboBox.SelectedIndex = 0;

            listSPs = new BindingList<string>(DatabaseHandler.getSPs());
            listSPs.Insert(0, "--Select--");
            procedureComboBox.DataSource = listSPs;
            procedureComboBox.SelectedIndex = 0;



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

        private void clearBtn_clicked(object sender, EventArgs e)
        {
            userComboBox.SelectedIndex = 0;
            rolePrivComboBox.SelectedIndex = 0;
            sysPrivComboBox.SelectedIndex = 0;

            objPrivComboBox.SelectedIndex = 0;
            tablePrivComboBox.SelectedIndex = 0;
            if (colColPrivComboBox.SelectedItem != null)
            {
                colColPrivComboBox.SelectedIndex = 0;
            }
            withGrantOptCheckBox.Checked = false;
            procedureComboBox.SelectedIndex = 0;
            funcComboBox.SelectedIndex = 0;
        }

        private void funcComboBox_selectionChanged(object sender, EventArgs e)
        {

        }

        private void procedureComboBox_slectionChanged(object sender, EventArgs e)
        {

        }
    }
}
