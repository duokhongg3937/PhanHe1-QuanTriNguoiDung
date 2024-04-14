using System;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormAddRole : Form
    {
        public FormAddRole()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string rolename = rolenameTextBox.Text.Trim();

            if (!DatabaseHandler.IsRoleExists(rolename))
            {
                bool result = DatabaseHandler.AddNewRole(rolename);

                if (result)
                {
                    MessageBox.Show($"Thành công tạo mới vai trò {rolename}");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không thể tạo mới vai trò");
                }
            }
            else
            {
                MessageBox.Show("Vai trò đã tồn tại");
            }
        }
    }
}
