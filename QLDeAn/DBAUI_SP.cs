using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeAn
{
    public partial class DBAUI_SP : UserControl
    {
        public static OracleConnection conNow = LoginUI.con;
        public DBAUI_SP()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectTsql = "select * from dba_sys_privs";
                OracleCommand cmd = new OracleCommand(selectTsql, conNow);
                cmd.BindByName = true;
                //cmd.Parameters.Add(new OracleParameter("owner", LoginUI.userUser));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grantView.DataSource = dataTable;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void searchGrantee_Click(object sender, EventArgs e)
        {
            string selectTsql = "select * from dba_sys_privs where grantee = :grantee";
            OracleCommand cmd = new OracleCommand(selectTsql, conNow);
            cmd.BindByName = true;
            cmd.Parameters.Add(new OracleParameter("grantee", searchTextBox.Text));
            OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            grantView.DataSource = dataTable;
        }

        private void grantRevokeButton_Click(object sender, EventArgs e)
        {
            DBAUI_SP_GrantF grantSPF = new DBAUI_SP_GrantF();
            grantSPF.Show();
        }
    }
}
