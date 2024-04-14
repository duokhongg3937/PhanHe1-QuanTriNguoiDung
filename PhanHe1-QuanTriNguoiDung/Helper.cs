using System.Data;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public static class Helper
    {
        public static void reloadUserTable(DataGridView userTable)
        {
            if (userTable != null)
            {
                DataTable dataTable = DatabaseHandler.GetAllUsers();
                userTable.DataSource = dataTable;
            }
        }
    }
}
