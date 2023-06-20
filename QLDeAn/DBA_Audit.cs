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
    public partial class DBA_Audit : UserControl
    {
        public static OracleConnection conNow = LoginUI.con;
        public DBA_Audit()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string selectTsql = "select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE from unified_audit_trail";
            OracleCommand cmd = new OracleCommand(selectTsql, conNow);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            auditTable.DataSource = dataTable;
        }
    }
}
