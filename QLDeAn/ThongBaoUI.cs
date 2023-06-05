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
    public partial class ThongBaoUI : Form
    {
        public ThongBaoUI()
        {
            InitializeComponent();
        }

        private void selectThongBao()
        {
            string selectTBsql = "SELECT * FROM QLDA_PDB1.THONGBAO";
            OracleDataAdapter adapter = new OracleDataAdapter(selectTBsql, NhanVienUI.conPDB) { SuppressGetDecimalInvalidCastException = true };
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ThongBaoView.DataSource = dataTable;
        }
        
        private void ThongBaoUI_Load(object sender, EventArgs e)
        {
            selectThongBao();
        }

        private void selectData_Click(object sender, EventArgs e)
        {
            selectThongBao();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            NhanVienUI.conPDB.Dispose();
            NhanVienUI.conPDB.Close();
            OracleConnection.ClearPool(NhanVienUI.conPDB);
            this.Hide();
        }


    }
}
