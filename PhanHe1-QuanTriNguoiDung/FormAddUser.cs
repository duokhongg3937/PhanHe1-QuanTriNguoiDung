using System;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (DatabaseHandler.AddNewUser(username, password))
            {
                MessageBox.Show($"Thành công tạo mới người dùng {username}");
                this.Close();
            } else
            {
                MessageBox.Show($"Username hoặc password không hợp lệ!");
            }
        }
    }
}
