using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void ManHinhDangNhap_Load(object sender, EventArgs e)
        {
            passwordTextBox.KeyPress += PasswordTextBox_KeyPress;
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();

            builder.DataSource = "localhost";
            builder.UserID = usernameTextBox.Text.Trim();
            builder.Password = passwordTextBox.Text.Trim();

            string connectionString = builder.ConnectionString;

            try
            {
                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();

                ManHinhChinh mainForm = new ManHinhChinh();
                mainForm.Show();

                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
