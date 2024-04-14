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
    public partial class FormRoles : Form
    {
        public FormRoles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DatabaseHandler.GetAllRoles();
            roleGridView.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddRole formAddRole = new FormAddRole();
            formAddRole.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DatabaseHandler.GetAllRoles();
            roleGridView.DataSource = dataTable;
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (roleGridView.SelectedRows.Count <= 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn 1 dòng user bất kỳ để xóa");
        //        return;
        //    }
        //    else if (roleGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
        //    {
        //        DataRow selectedRow = selectedDataRowView.Row;
        //        string username = (string)selectedRow["USERNAME"];

        //        DialogResult res = MessageBox.Show($"Bạn đã chọn user: {username} \n\n\n Bạn có chắc chắn muốn xóa user này?",
        //                "Xác nhận xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (res == DialogResult.Yes)
        //        {
        //            if (DatabaseHandler.DropUser(username))
        //            {
        //                MessageBox.Show($"Thành công xóa user {username}", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                DataTable dataTable = DatabaseHandler.GetAllUsers();
        //                roleGridView.DataSource = dataTable;
        //            }
        //        }
        //    }
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (roleGridView.SelectedRows.Count <= 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn 1 dòng user bất kỳ để chỉnh sửa");
        //        return;
        //    }
        //    else if (roleGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
        //    {
        //        DataRow selectedRow = selectedDataRowView.Row;
        //        string username = (string)selectedRow["ROLENAME"];

        //        FormUpdateUser formUpdateUser = new FormUpdateUser(username);
        //        formUpdateUser.Show();
        //    }
        //}

        private void roleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
