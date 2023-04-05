using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLDeAn
{
    public partial class UserAndRoleUI : UserControl
    {
        public UserAndRoleUI()
        {
            InitializeComponent();
        }
        public static OracleConnection conNow;

        private void UserAndRole_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
            view_users();
            view_roles();
        }

        private void view_users()
        {

            string sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void view_roles()
        {
            string sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
