
namespace QLDeAn
{
    partial class NhanVienUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NhanVienTab = new System.Windows.Forms.TabControl();
            this.NhanVienTable = new System.Windows.Forms.TabPage();
            this.PhongBanTable = new System.Windows.Forms.TabPage();
            this.PhanCongTable = new System.Windows.Forms.TabPage();
            this.DeAnTable = new System.Windows.Forms.TabPage();
            this.ThongBaoTable = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.nhanVienUI_NVTable1 = new QLDeAn.NhanVienUI_NVTable();
            this.NhanVienTab.SuspendLayout();
            this.NhanVienTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienTab
            // 
            this.NhanVienTab.Controls.Add(this.NhanVienTable);
            this.NhanVienTab.Controls.Add(this.PhongBanTable);
            this.NhanVienTab.Controls.Add(this.PhanCongTable);
            this.NhanVienTab.Controls.Add(this.DeAnTable);
            this.NhanVienTab.Controls.Add(this.ThongBaoTable);
            this.NhanVienTab.Location = new System.Drawing.Point(12, 17);
            this.NhanVienTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhanVienTab.Name = "NhanVienTab";
            this.NhanVienTab.SelectedIndex = 0;
            this.NhanVienTab.Size = new System.Drawing.Size(1481, 622);
            this.NhanVienTab.TabIndex = 0;
            // 
            // NhanVienTable
            // 
            this.NhanVienTable.Controls.Add(this.nhanVienUI_NVTable1);
            this.NhanVienTable.Location = new System.Drawing.Point(4, 25);
            this.NhanVienTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NhanVienTable.Name = "NhanVienTable";
            this.NhanVienTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NhanVienTable.Size = new System.Drawing.Size(1473, 593);
            this.NhanVienTable.TabIndex = 0;
            this.NhanVienTable.Text = "NHÂN VIÊN";
            this.NhanVienTable.UseVisualStyleBackColor = true;
            // 
            // PhongBanTable
            // 
            this.PhongBanTable.Location = new System.Drawing.Point(4, 25);
            this.PhongBanTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhongBanTable.Name = "PhongBanTable";
            this.PhongBanTable.Size = new System.Drawing.Size(1473, 514);
            this.PhongBanTable.TabIndex = 2;
            this.PhongBanTable.Text = "PHÒNG BAN";
            this.PhongBanTable.UseVisualStyleBackColor = true;
            // 
            // PhanCongTable
            // 
            this.PhanCongTable.Location = new System.Drawing.Point(4, 25);
            this.PhanCongTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhanCongTable.Name = "PhanCongTable";
            this.PhanCongTable.Size = new System.Drawing.Size(1473, 514);
            this.PhanCongTable.TabIndex = 1;
            this.PhanCongTable.Text = "PHÂN CÔNG";
            this.PhanCongTable.UseVisualStyleBackColor = true;
            // 
            // DeAnTable
            // 
            this.DeAnTable.Location = new System.Drawing.Point(4, 25);
            this.DeAnTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeAnTable.Name = "DeAnTable";
            this.DeAnTable.Size = new System.Drawing.Size(1473, 514);
            this.DeAnTable.TabIndex = 3;
            this.DeAnTable.Text = "ĐỀ ÁN";
            this.DeAnTable.UseVisualStyleBackColor = true;
            // 
            // ThongBaoTable
            // 
            this.ThongBaoTable.Location = new System.Drawing.Point(4, 25);
            this.ThongBaoTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThongBaoTable.Name = "ThongBaoTable";
            this.ThongBaoTable.Size = new System.Drawing.Size(1473, 514);
            this.ThongBaoTable.TabIndex = 4;
            this.ThongBaoTable.Text = "THÔNG BÁO";
            this.ThongBaoTable.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1418, 641);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "ĐÓNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1175, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "XIN CHÀO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1366, 6);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(123, 26);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "ĐĂNG XUẤT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // nhanVienUI_NVTable1
            // 
            this.nhanVienUI_NVTable1.Location = new System.Drawing.Point(4, 4);
            this.nhanVienUI_NVTable1.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienUI_NVTable1.Name = "nhanVienUI_NVTable1";
            this.nhanVienUI_NVTable1.Size = new System.Drawing.Size(1478, 583);
            this.nhanVienUI_NVTable1.TabIndex = 0;
            // 
            // NhanVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 681);
            this.ControlBox = false;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NhanVienTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVienUI";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.NhanVienUI_Load);
            this.NhanVienTab.ResumeLayout(false);
            this.NhanVienTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl NhanVienTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabPage NhanVienTable;
        private System.Windows.Forms.TabPage PhanCongTable;
        private System.Windows.Forms.TabPage PhongBanTable;
        private System.Windows.Forms.TabPage DeAnTable;
        private System.Windows.Forms.TabPage ThongBaoTable;
        private NhanVienUI_NVTable nhanVienUI_NVTable1;
    }
}