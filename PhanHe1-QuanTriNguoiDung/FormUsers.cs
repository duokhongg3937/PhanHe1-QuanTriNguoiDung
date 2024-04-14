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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            Helper.reloadUserTable(userGridView);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            var result = formAddUser.ShowDialog();

            if (result == DialogResult.OK)
            {
                Helper.reloadUserTable(userGridView);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng user bất kỳ để xóa");
                return;
            } 
            else if (userGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
            {
                DataRow selectedRow = selectedDataRowView.Row;
                string username = (string)selectedRow["USERNAME"];

                DialogResult res = MessageBox.Show($"Bạn đã chọn user: {username} \n\n\n Bạn có chắc chắn muốn xóa user này?",
                        "Xác nhận xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (DatabaseHandler.DropUser(username))
                    {
                        MessageBox.Show($"Thành công xóa user {username}", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.reloadUserTable(userGridView);
                    }
                } 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng user bất kỳ để chỉnh sửa");
                return;
            }
            else if (userGridView.SelectedRows[0].DataBoundItem is DataRowView selectedDataRowView)
            {
                DataRow selectedRow = selectedDataRowView.Row;
                string username = (string)selectedRow["USERNAME"];

                FormUpdateUser formUpdateUser = new FormUpdateUser(username);
                DialogResult result = formUpdateUser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Helper.reloadUserTable(userGridView);
                }
            }
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
