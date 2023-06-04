
namespace QLDeAn
{
    partial class NhanVienUI_NVTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NhanVienTableView = new System.Windows.Forms.DataGridView();
            this.selectData = new System.Windows.Forms.Button();
            this.insertData = new System.Windows.Forms.Button();
            this.updateData = new System.Windows.Forms.Button();
            this.deleteData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNVTextBox = new System.Windows.Forms.TextBox();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SDTTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LuongTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhuCapTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VaiTroTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaNQLTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MaPBTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NgaySinhTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienTableView
            // 
            this.NhanVienTableView.AllowUserToOrderColumns = true;
            this.NhanVienTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhanVienTableView.Location = new System.Drawing.Point(19, 34);
            this.NhanVienTableView.Name = "NhanVienTableView";
            this.NhanVienTableView.RowHeadersWidth = 51;
            this.NhanVienTableView.Size = new System.Drawing.Size(751, 305);
            this.NhanVienTableView.TabIndex = 0;
            this.NhanVienTableView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanVienTableView_CellClick);
            this.NhanVienTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanVienTableView_CellContentClick);
            // 
            // selectData
            // 
            this.selectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectData.Location = new System.Drawing.Point(791, 34);
            this.selectData.Name = "selectData";
            this.selectData.Size = new System.Drawing.Size(113, 25);
            this.selectData.TabIndex = 1;
            this.selectData.Text = "LẤY DỮ LIỆU";
            this.selectData.UseVisualStyleBackColor = true;
            this.selectData.Click += new System.EventHandler(this.selectData_Click);
            // 
            // insertData
            // 
            this.insertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertData.Location = new System.Drawing.Point(791, 65);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(113, 25);
            this.insertData.TabIndex = 2;
            this.insertData.Text = "THÊM DỮ LIỆU";
            this.insertData.UseVisualStyleBackColor = true;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // updateData
            // 
            this.updateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateData.Location = new System.Drawing.Point(791, 96);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(113, 25);
            this.updateData.TabIndex = 3;
            this.updateData.Text = "CẬP NHẬT";
            this.updateData.UseVisualStyleBackColor = true;
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // deleteData
            // 
            this.deleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteData.Location = new System.Drawing.Point(791, 127);
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(113, 25);
            this.deleteData.TabIndex = 4;
            this.deleteData.Text = "XÓA DỮ LIỆU";
            this.deleteData.UseVisualStyleBackColor = true;
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẢNG: NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MANV";
            // 
            // MaNVTextBox
            // 
            this.MaNVTextBox.Location = new System.Drawing.Point(67, 345);
            this.MaNVTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaNVTextBox.Name = "MaNVTextBox";
            this.MaNVTextBox.Size = new System.Drawing.Size(96, 20);
            this.MaNVTextBox.TabIndex = 7;
            // 
            // HoTenTextBox
            // 
            this.HoTenTextBox.Enabled = false;
            this.HoTenTextBox.Location = new System.Drawing.Point(218, 344);
            this.HoTenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoTenTextBox.Name = "HoTenTextBox";
            this.HoTenTextBox.Size = new System.Drawing.Size(96, 20);
            this.HoTenTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TENNV";
            // 
            // GioiTinhTextBox
            // 
            this.GioiTinhTextBox.Enabled = false;
            this.GioiTinhTextBox.Location = new System.Drawing.Point(383, 345);
            this.GioiTinhTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GioiTinhTextBox.Name = "GioiTinhTextBox";
            this.GioiTinhTextBox.Size = new System.Drawing.Size(96, 20);
            this.GioiTinhTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PHAI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NGSINH";
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(66, 369);
            this.DiaChiTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(96, 20);
            this.DiaChiTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DIACHI";
            // 
            // SDTTextBox
            // 
            this.SDTTextBox.Location = new System.Drawing.Point(218, 369);
            this.SDTTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SDTTextBox.Name = "SDTTextBox";
            this.SDTTextBox.Size = new System.Drawing.Size(96, 20);
            this.SDTTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SĐT";
            // 
            // LuongTextBox
            // 
            this.LuongTextBox.Enabled = false;
            this.LuongTextBox.Location = new System.Drawing.Point(383, 369);
            this.LuongTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LuongTextBox.Name = "LuongTextBox";
            this.LuongTextBox.Size = new System.Drawing.Size(96, 20);
            this.LuongTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "LUONG";
            // 
            // PhuCapTextBox
            // 
            this.PhuCapTextBox.Enabled = false;
            this.PhuCapTextBox.Location = new System.Drawing.Point(561, 369);
            this.PhuCapTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhuCapTextBox.Name = "PhuCapTextBox";
            this.PhuCapTextBox.Size = new System.Drawing.Size(96, 20);
            this.PhuCapTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 371);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PHUCAP";
            // 
            // VaiTroTextBox
            // 
            this.VaiTroTextBox.Enabled = false;
            this.VaiTroTextBox.Location = new System.Drawing.Point(66, 393);
            this.VaiTroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VaiTroTextBox.Name = "VaiTroTextBox";
            this.VaiTroTextBox.Size = new System.Drawing.Size(96, 20);
            this.VaiTroTextBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "VAITRO";
            // 
            // MaNQLTextBox
            // 
            this.MaNQLTextBox.Enabled = false;
            this.MaNQLTextBox.Location = new System.Drawing.Point(218, 393);
            this.MaNQLTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaNQLTextBox.Name = "MaNQLTextBox";
            this.MaNQLTextBox.Size = new System.Drawing.Size(96, 20);
            this.MaNQLTextBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "MANQL";
            // 
            // MaPBTextBox
            // 
            this.MaPBTextBox.Enabled = false;
            this.MaPBTextBox.Location = new System.Drawing.Point(383, 393);
            this.MaPBTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaPBTextBox.Name = "MaPBTextBox";
            this.MaPBTextBox.Size = new System.Drawing.Size(96, 20);
            this.MaPBTextBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 396);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "MAPB";
            // 
            // NgaySinhTextBox
            // 
            this.NgaySinhTextBox.Location = new System.Drawing.Point(561, 344);
            this.NgaySinhTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NgaySinhTextBox.Name = "NgaySinhTextBox";
            this.NgaySinhTextBox.Size = new System.Drawing.Size(96, 20);
            this.NgaySinhTextBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(776, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 55);
            this.label13.TabIndex = 31;
            this.label13.Text = "- Role Tài chính có thể nhập NULL trên NGSINH, DIACHI, SĐT nếu không muốn Update " +
    "dữ liệu 3 trường đó";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(776, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 67);
            this.label14.TabIndex = 32;
            this.label14.Text = "- Role Nhân sự có thể nhập NULL hoặc để trống trên LUONG, PHUCAP nếu không muốn I" +
    "nsert, Update dữ liệu 2 trường đó\r\n";
            // 
            // NhanVienUI_NVTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NgaySinhTextBox);
            this.Controls.Add(this.MaPBTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MaNQLTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VaiTroTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhuCapTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LuongTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SDTTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DiaChiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GioiTinhTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HoTenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaNVTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteData);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.selectData);
            this.Controls.Add(this.NhanVienTableView);
            this.Name = "NhanVienUI_NVTable";
            this.Size = new System.Drawing.Size(929, 415);
            this.Load += new System.EventHandler(this.NhanVienUI_NVTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NhanVienTableView;
        private System.Windows.Forms.Button selectData;
        private System.Windows.Forms.Button insertData;
        private System.Windows.Forms.Button updateData;
        private System.Windows.Forms.Button deleteData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaNVTextBox;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GioiTinhTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SDTTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LuongTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhuCapTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VaiTroTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaNQLTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MaPBTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NgaySinhTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
