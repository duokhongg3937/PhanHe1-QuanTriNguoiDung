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
            string selectAllUsersQuery = "select USERNAME, USER_ID, PASSWORD, EXPIRY_DATE, CREATED, PROFILE  " +
                "from DBA_USERS where ACCOUNT_STATUS = 'OPEN'";
            DataTable dataTable = DatabaseHandler
                .ExecuteQuery(selectAllUsersQuery);
            userGridView.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
