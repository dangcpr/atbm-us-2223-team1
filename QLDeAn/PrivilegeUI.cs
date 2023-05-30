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
        public static DataGridView data_grid_view1;
        public static DataGridView data_grid_view2;

        private void UserAndRole_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
            view_table_privil();
            view_col_privil();
        }


        public void view_table_privil()
        {
            string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDA_%' OR TABLE_NAME LIKE 'V_QLDA_%' ";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            data_grid_view1 = dataGridView1;
        }

        public void view_col_privil()
        {

            string sql = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'QLDA_%' ";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;
            data_grid_view2 = dataGridView2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void grantPrivilege_Click(object sender, EventArgs e)
        {
            GrantPrivil_F grantPrivil = new GrantPrivil_F();
            grantPrivil.Show();
        }

        private void revokePrivilege_Click(object sender, EventArgs e)
        {
            RevokePrivil_F revokePrivil = new RevokePrivil_F();
            revokePrivil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void colLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
