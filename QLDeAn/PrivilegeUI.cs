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
    public partial class PrivilegeUI : UserControl
    {
        public PrivilegeUI()
        {
            InitializeComponent();

        }

        public static OracleConnection conNow;

        private void PrivilegeUI_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
            view_roles_privilege();
        }

        private void view_roles_privilege()
        {
            string sql = "SELECT grantee, table_name, privilege FROM dba_tab_privs";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void grantPrivilege_Click(object sender, EventArgs e)
        {
            GrantPrivil_F grantPrivil = new GrantPrivil_F();
            grantPrivil.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
