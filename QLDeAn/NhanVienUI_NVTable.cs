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
using System.Data.OleDb;
using System.Globalization;

namespace QLDeAn
{
    public partial class NhanVienUI_NVTable : UserControl
    {
        public static OracleConnection conNow;
        public NhanVienUI_NVTable()
        {

            InitializeComponent();
        }
        private void NhanVienUI_NVTable_Load(object sender, EventArgs e)
        {
            if (LoginUI.roleUser == "Tài chính")
            {
                LuongTextBox.Enabled = true;
                PhuCapTextBox.Enabled = true;
            }
            if (LoginUI.roleUser == "Nhân sự")
            {
                LuongTextBox.Enabled = true;
                PhuCapTextBox.Enabled = true;
                HoTenTextBox.Enabled = true;
                GioiTinhTextBox.Enabled = true;
                NgaySinhTextBox.Enabled = true;
                DiaChiTextBox.Enabled = true;
                VaiTroTextBox.Enabled = true;
                MaNQLTextBox.Enabled = true;
                MaPBTextBox.Enabled = true;
            }
        }
        private void selectData_Click(object sender, EventArgs e)
        {
            try
            {
                conNow = LoginUI.con;
                string selectNVsql = "";
                switch(LoginUI.roleUser)
                {
                    case "Nhân viên":
                    case "Quản lý":
                    case "Trưởng phòng":
                    case "Tài chính":
                    case "Trưởng dự án":
                        selectNVsql = "SELECT * FROM QLDA.QLDA_NHANVIEN";
                        break;
                    case "Nhân sự":
                        selectNVsql = "SELECT * FROM QLDA.V_QLDA_NHANVIEN_NS";
                        break;

                }
                OracleDataAdapter adapter = new OracleDataAdapter(selectNVsql, conNow) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                NhanVienTableView.DataSource = dataTable;
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            //Insert data from TextBox
            try
            {
                conNow = LoginUI.con;
                if (LoginUI.roleUser != "Nhân sự")
                {
                    string insertNVsql = "INSERT INTO QLDA.QLDA_NHANVIEN VALUES (:MaNV, :HoTen, :GioiTinh, :NgaySinh, :DiaChi, :SDT, :Luong, :PhuCap, :VaiTro, :MaNQL, :MaPB)";
                    OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("HoTen", OracleDbType.Varchar2, HoTenTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("GioiTinh", OracleDbType.Varchar2, GioiTinhTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("NgaySinh", OracleDbType.Char, NgaySinhTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("DiaChi", OracleDbType.Varchar2, DiaChiTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("SDT", OracleDbType.Char, SDTTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("Luong", OracleDbType.BinaryFloat, LuongTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("PhuCap", OracleDbType.BinaryFloat, PhuCapTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("VaiTro", OracleDbType.Varchar2, VaiTroTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaNQL", OracleDbType.Char, MaNQLTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaPB", OracleDbType.Char, MaPBTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                }
                else
                {
                    string insertNVsql = "INSERT INTO QLDA.V_QLDA_NHANVIEN_NS (MaNV, TenNV, Phai, NgaySinh, DiaChi, SODT, VaiTro, MaNQL, MaPB) VALUES (:MaNV, :HoTen, :GioiTinh, TO_DATE(:NgaySinh, 'DD/MM/YYYY'), :DiaChi, :SDT, :VaiTro, :MaNQL, :MaPB)";
                    OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text, System.Data.ParameterDirection.Input));
                    //cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HoTen", OracleDbType.Varchar2, HoTenTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("GioiTinh", OracleDbType.Varchar2, GioiTinhTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("NgaySinh", OracleDbType.Char, NgaySinhTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("DiaChi", OracleDbType.Varchar2, DiaChiTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("SDT", OracleDbType.Char, SDTTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("VaiTro", OracleDbType.Varchar2, VaiTroTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaNQL", OracleDbType.Char, MaNQLTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaPB", OracleDbType.Char, MaPBTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                }
                MessageBox.Show("Insert success!");
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            //Update data from TextBox to QLDA_NHANVIEN (NgaySinh,DiaChi,SDT)     
            try
            {
                conNow = LoginUI.con;
                if (LoginUI.roleUser != "Tài chính" && LoginUI.roleUser != "Nhân sự")
                {
                    string updateNVsql = "UPDATE QLDA.QLDA_NHANVIEN SET NgaySinh = TO_DATE(:NgaySinh, 'DD/MM/YYYY'), DiaChi = :DiaChi, SODT = :SDT WHERE MaNV = :MaNV";
                    OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("NgaySinh", NgaySinhTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DiaChi", DiaChiTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("SDT", SDTTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    int count_update = cmd.ExecuteNonQuery();
                    MessageBox.Show(count_update + " rows update success!");
                    return;
                }
                if (LoginUI.roleUser == "Tài chính")
                {
                    string updateNVsql = "UPDATE QLDA.QLDA_NHANVIEN SET ";
                    OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                    if (NgaySinhTextBox.Text != "NULL") 
                    {
                        cmd.CommandText += "NgaySinh = TO_DATE(:NgaySinh, 'DD/MM/YYYY'),";
                        cmd.Parameters.Add(new OracleParameter("NgaySinh", NgaySinhTextBox.Text));
                    }
                    if (DiaChiTextBox.Text != "NULL")
                    {
                        cmd.CommandText += "DiaChi = :DiaChi,";
                        cmd.Parameters.Add(new OracleParameter("NgaySinh", DiaChiTextBox.Text));
                    }
                    if (SDTTextBox.Text != "NULL")
                    {
                        cmd.CommandText += "SODT = :SDT,";
                        cmd.Parameters.Add(new OracleParameter("NgaySinh", SDTTextBox.Text));
                    }
                    cmd.CommandText += "Luong = :Luong, PHUCAP = :PhuCap WHERE MaNV = :MaNV";

                    cmd.Parameters.Add(new OracleParameter("Luong", OracleDbType.BinaryFloat, LuongTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("PhuCap", OracleDbType.BinaryFloat, PhuCapTextBox.Text, System.Data.ParameterDirection.Input));                    
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    int count_update = cmd.ExecuteNonQuery();
                    MessageBox.Show(count_update + " rows update success!");
                    return;
                }

                if (LoginUI.roleUser == "Nhân sự")
                {
                    string updateNVsql = "UPDATE QLDA.V_QLDA_NHANVIEN_NS SET TenNV = :TenNV,Phai = :Phai, NgaySinh = TO_DATE(:NgaySinh,'DD/MM/YYYY'), DiaChi = :DiaChi, SODT = :SDT,VaiTro = :VaiTro, MaNQL = :MaNQL, MaPB = :MaPB,";
                    OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("TenNV", HoTenTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("Phai", GioiTinhTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("NgaySinh", NgaySinhTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DiaChi", DiaChiTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("SDT", SDTTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("VaiTro", VaiTroTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaNQL", MaNQLTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaPB", MaPBTextBox.Text));
                    if (LuongTextBox.Text != "NULL" && LuongTextBox.Text != "")
                    {
                        cmd.CommandText += "Luong = :Luong,";
                        cmd.Parameters.Add(new OracleParameter("Luong", LuongTextBox.Text));
                    }
                    if (PhuCapTextBox.Text != "NULL" && PhuCapTextBox.Text != "")
                    {
                        cmd.CommandText += "PhuCap = :PhuCap,";
                        cmd.Parameters.Add(new OracleParameter("PhuCap", PhuCapTextBox.Text));
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                    cmd.CommandText += " WHERE MaNV = :MaNV";
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    int count_update = cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                    MessageBox.Show(count_update + " rows update success!");
                    return;
                }

            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }       
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            //Delete data from TextBox to QLDA_NHANVIEN
            conNow = LoginUI.con;
            try
            {
                if (LoginUI.roleUser != "Nhân sự")
                {
                    string deleteNVsql = "DELETE FROM QLDA.QLDA_NHANVIEN WHERE MaNV = :MaNV";
                    OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    MessageBox.Show("Delete success!");
                }
                else
                {
                    string deleteNVsql = "DELETE FROM QLDA.V_QLDA_NHANVIEN_NS WHERE MaNV = :MaNV";
                    OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    MessageBox.Show("Delete success!");
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void NhanVienTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NhanVienTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fill in Textbox when clicking a row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.NhanVienTableView.Rows[e.RowIndex];
                MaNVTextBox.Text = row.Cells[0].Value.ToString();
                HoTenTextBox.Text = row.Cells[1].Value.ToString();
                GioiTinhTextBox.Text = row.Cells[2].Value.ToString();
                NgaySinhTextBox.Text = DateTime.ParseExact(row.Cells[3].Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                DiaChiTextBox.Text = row.Cells[4].Value.ToString();
                SDTTextBox.Text = row.Cells[5].Value.ToString();
                LuongTextBox.Text = row.Cells[6].Value.ToString();
                PhuCapTextBox.Text = row.Cells[7].Value.ToString();
                VaiTroTextBox.Text = row.Cells[8].Value.ToString();
                MaNQLTextBox.Text = row.Cells[9].Value.ToString();
                MaPBTextBox.Text = row.Cells[10].Value.ToString();
            }

        }

        private void nullButton_Click(object sender, EventArgs e)
        {
        }
    }
}
