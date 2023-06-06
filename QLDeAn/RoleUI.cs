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
    public partial class RoleUI : UserControl
    {
        public RoleUI()
        {
            InitializeComponent();
        }

        private void RoleUI_Load(object sender, EventArgs e)
        {


        }
        public static OracleConnection conNow = LoginUI.con;
        public static DataGridView data_grid_view1;
        private void view_user_role()
        {

            string sql = "select * from dba_role_privs";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;

        }
        private void grantRole_Click(object sender, EventArgs e)
        {
            GrantRole_F grantRole = new GrantRole_F();
            grantRole.Show();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revokePrivilege_Click(object sender, EventArgs e)
        {
            RevokeRole_F revokerole = new RevokeRole_F();
            revokerole.Show();
        }

        private void findU_Click(object sender, EventArgs e)
        {
            string sql;
            if (textFU.Text.Length == 0)
                sql = "select * from dba_role_privs";
            else
                sql = "select * from dba_role_privs where grantee = \'" + textFU.Text + '\'';
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;
        }

        private void textFU_TextChanged(object sender, EventArgs e)
        {

        }

        private void findR_Click(object sender, EventArgs e)
        {
            string sql;
            if (textFR.Text.Length == 0)
                sql = "select * from dba_role_privs";
            else
                sql = "select * from dba_role_privs where granted_role = \'" + textFR.Text + '\'';
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;
        }
        private void textFR_TextChanged(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            view_user_role();
        }
    }
}
