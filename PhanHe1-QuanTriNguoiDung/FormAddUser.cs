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

            if (!DatabaseHandler.IsUserExists(username))
            {
                bool result = DatabaseHandler.AddNewUser(username, password);

                if (result)
                {
                    MessageBox.Show($"Thành công tạo mới người dùng {username}");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể tạo mới người dùng");
                    this.DialogResult = DialogResult.No;
                }
            } 
            else
            {
                MessageBox.Show("Tên người dùng đã tồn tại");
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
