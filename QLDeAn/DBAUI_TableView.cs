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
    public partial class DBAUI_TableView : UserControl
    {
        public static OracleConnection conNow = LoginUI.con;
        public DBAUI_TableView()
        {
            InitializeComponent();
        }


        private void selectData()
        {
            try
            {
                string selectTsql = "select * from dba_tables where owner = :owner";
                OracleCommand cmd = new OracleCommand(selectTsql, conNow);
                cmd.BindByName = true;
                cmd.Parameters.Add(new OracleParameter("owner", LoginUI.userUser));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableView.DataSource = dataTable;

                string selectVsql = "select * from dba_views where owner = :owner";
                OracleCommand cmd2 = new OracleCommand(selectVsql, conNow);
                cmd2.BindByName = true;
                cmd2.Parameters.Add(new OracleParameter("owner", LoginUI.userUser));
                OracleDataAdapter adapter2 = new OracleDataAdapter(cmd2) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                viewView.DataSource = dataTable2;
            } 
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            selectData();
        }

        private void DBAUI_TableView_Load(object sender, EventArgs e)
        {

        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            DBAUI_TableView_CreateTable_F createTableUI = new DBAUI_TableView_CreateTable_F();
            createTableUI.Show();
        }
    }
}
