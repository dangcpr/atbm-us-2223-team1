
namespace QLDeAn
{
    partial class NhanVienUI_PCTable
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
            this.MaDATextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThoiGianTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.searchNV = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchDA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienTableView
            // 
            this.NhanVienTableView.AllowUserToOrderColumns = true;
            this.NhanVienTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhanVienTableView.Location = new System.Drawing.Point(19, 38);
            this.NhanVienTableView.Name = "NhanVienTableView";
            this.NhanVienTableView.RowHeadersWidth = 51;
            this.NhanVienTableView.Size = new System.Drawing.Size(912, 362);
            this.NhanVienTableView.TabIndex = 0;
            this.NhanVienTableView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanVienTableView_CellClick);
            this.NhanVienTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanVienTableView_CellContentClick);
            // 
            // selectData
            // 
            this.selectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectData.Location = new System.Drawing.Point(963, 38);
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
            this.insertData.Location = new System.Drawing.Point(963, 69);
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
            this.updateData.Location = new System.Drawing.Point(963, 100);
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
            this.deleteData.Location = new System.Drawing.Point(963, 131);
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
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẢNG: PHÂN CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MANV";
            // 
            // MaNVTextBox
            // 
            this.MaNVTextBox.AllowDrop = true;
            this.MaNVTextBox.Location = new System.Drawing.Point(80, 406);
            this.MaNVTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaNVTextBox.Name = "MaNVTextBox";
            this.MaNVTextBox.Size = new System.Drawing.Size(157, 20);
            this.MaNVTextBox.TabIndex = 7;
            // 
            // MaDATextBox
            // 
            this.MaDATextBox.AllowDrop = true;
            this.MaDATextBox.Location = new System.Drawing.Point(301, 406);
            this.MaDATextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaDATextBox.Name = "MaDATextBox";
            this.MaDATextBox.Size = new System.Drawing.Size(157, 20);
            this.MaDATextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MADA";
            // 
            // ThoiGianTextBox
            // 
            this.ThoiGianTextBox.AllowDrop = true;
            this.ThoiGianTextBox.Location = new System.Drawing.Point(540, 406);
            this.ThoiGianTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThoiGianTextBox.Name = "ThoiGianTextBox";
            this.ThoiGianTextBox.Size = new System.Drawing.Size(157, 20);
            this.ThoiGianTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "THOIGIAN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(960, 171);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Tìm kiếm PC";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchNV
            // 
            this.searchNV.Location = new System.Drawing.Point(1002, 186);
            this.searchNV.Margin = new System.Windows.Forms.Padding(2);
            this.searchNV.Name = "searchNV";
            this.searchNV.Size = new System.Drawing.Size(76, 20);
            this.searchNV.TabIndex = 34;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1003, 234);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 19);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Tìm kiếm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(960, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "MANV";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "MADA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchDA
            // 
            this.searchDA.Location = new System.Drawing.Point(1002, 210);
            this.searchDA.Margin = new System.Windows.Forms.Padding(2);
            this.searchDA.Name = "searchDA";
            this.searchDA.Size = new System.Drawing.Size(76, 20);
            this.searchDA.TabIndex = 37;
            // 
            // NhanVienUI_PCTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchNV);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ThoiGianTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaDATextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaNVTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteData);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.selectData);
            this.Controls.Add(this.NhanVienTableView);
            this.Name = "NhanVienUI_PCTable";
            this.Size = new System.Drawing.Size(1108, 474);
            this.Load += new System.EventHandler(this.NhanVienUI_PCTable_Load);
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
        private System.Windows.Forms.TextBox MaDATextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ThoiGianTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox searchNV;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchDA;
    }
}
