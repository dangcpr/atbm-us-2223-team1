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
        public static OracleConnection conNow = LoginUI.con;
        public static DataGridView data_grid_view1;
        public static DataGridView data_grid_view2;

        private void UserAndRole_Load(object sender, EventArgs e)
        {

        }

        private void view_users()
        {

            string sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;

        }

        private void view_roles()
        {
            string sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            data_grid_view2 = dataGridView2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUser_F deleteuser = new DeleteUser_F();
            deleteuser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser_F createuser = new CreateUser_F();
            createuser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUser_F updateuser = new UpdateUser_F();
            updateuser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateRole_F createrole = new CreateRole_F();
            createrole.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteRole_F deleterole = new DeleteRole_F();
            deleterole.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateRole_F updaterole = new UpdateRole_F();
            updaterole.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findU_Click(object sender, EventArgs e)
        {
            string sql;
            if (textFU.Text.Length == 0)
                sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";
            else
                sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS WHERE USERNAME = \'" + textFU.Text + '\'';
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;
        }


        private void textFR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFU_TextChanged(object sender, EventArgs e)
        {

        }

        private void findR_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (textFR.Text.Length == 0)
                sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";
            else
                sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES where ROLE = \'" + textFR.Text + '\'';
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            data_grid_view2 = dataGridView2;
        }

        private void select_Click(object sender, EventArgs e)
        {
            view_users();
            view_roles();
        }
    }
}
