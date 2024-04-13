using System;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormUpdateUser : Form
    {
        private string _username;

        public FormUpdateUser(string username)
        {
            InitializeComponent();
            _username = username;  
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng không để trống password!");
                return;
            }
            else
            {
                if (DatabaseHandler.UpdateUser(_username, password))
                {
                    MessageBox.Show("Cập nhật thành công!!");
                    this.Close();
                }
            }
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = _username;
            usernameTextBox.Enabled = false;
        }
    }
}
