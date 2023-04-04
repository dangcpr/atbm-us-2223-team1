
namespace QLDeAn
{
    partial class GrantPrivil_F
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
            this.Close = new System.Windows.Forms.Button();
            this.userrolelabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.privil = new System.Windows.Forms.ComboBox();
            this.withgrantoption = new System.Windows.Forms.CheckBox();
            this.column = new System.Windows.Forms.CheckedListBox();
            this.grantButton = new System.Windows.Forms.Button();
            this.roleuser = new System.Windows.Forms.TextBox();
            this.privillable = new System.Windows.Forms.Label();
            this.tablelabel = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.ComboBox();
            this.columnlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetUR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(450, 232);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // userrolelabel
            // 
            this.userrolelabel.AutoSize = true;
            this.userrolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrolelabel.ForeColor = System.Drawing.Color.Black;
            this.userrolelabel.Location = new System.Drawing.Point(30, 19);
            this.userrolelabel.Name = "userrolelabel";
            this.userrolelabel.Size = new System.Drawing.Size(125, 18);
            this.userrolelabel.TabIndex = 12;
            this.userrolelabel.Text = "Username/Role";
            this.userrolelabel.Click += new System.EventHandler(this.userrolelabel_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.ForeColor = System.Drawing.Color.Red;
            this.resultlabel.Location = new System.Drawing.Point(30, 84);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(65, 18);
            this.resultlabel.TabIndex = 14;
            this.resultlabel.Text = "Kết quả";
            this.resultlabel.Click += new System.EventHandler(this.resultlabel_Click);
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(173, 46);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(85, 27);
            this.check.TabIndex = 15;
            this.check.Text = "Kiểm tra";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(170, 84);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(113, 18);
            this.result.TabIndex = 16;
            this.result.Text = "Chưa kiểm tra";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // privil
            // 
            this.privil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privil.Enabled = false;
            this.privil.FormattingEnabled = true;
            this.privil.Items.AddRange(new object[] {
            "INSERT",
            "DELETE",
            "UPDATE",
            "SELECT"});
            this.privil.Location = new System.Drawing.Point(173, 119);
            this.privil.Name = "privil";
            this.privil.Size = new System.Drawing.Size(162, 24);
            this.privil.TabIndex = 18;
            this.privil.SelectedIndexChanged += new System.EventHandler(this.privil_SelectedIndexChanged);
            // 
            // withgrantoption
            // 
            this.withgrantoption.AutoSize = true;
            this.withgrantoption.Enabled = false;
            this.withgrantoption.Location = new System.Drawing.Point(173, 184);
            this.withgrantoption.Name = "withgrantoption";
            this.withgrantoption.Size = new System.Drawing.Size(175, 21);
            this.withgrantoption.TabIndex = 19;
            this.withgrantoption.Text = "WITH GRANT OPTION";
            this.withgrantoption.UseVisualStyleBackColor = true;
            this.withgrantoption.CheckedChanged += new System.EventHandler(this.withgrantoption_CheckedChanged);
            // 
            // column
            // 
            this.column.Enabled = false;
            this.column.FormattingEnabled = true;
            this.column.Location = new System.Drawing.Point(375, 40);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(150, 157);
            this.column.TabIndex = 22;
            this.column.SelectedIndexChanged += new System.EventHandler(this.column_SelectedIndexChanged);
            // 
            // grantButton
            // 
            this.grantButton.Location = new System.Drawing.Point(121, 232);
            this.grantButton.Name = "grantButton";
            this.grantButton.Size = new System.Drawing.Size(162, 33);
            this.grantButton.TabIndex = 23;
            this.grantButton.Text = "Cấp quyền";
            this.grantButton.UseVisualStyleBackColor = true;
            this.grantButton.Click += new System.EventHandler(this.grantButton_Click);
            // 
            // roleuser
            // 
            this.roleuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleuser.Location = new System.Drawing.Point(173, 16);
            this.roleuser.Name = "roleuser";
            this.roleuser.Size = new System.Drawing.Size(162, 24);
            this.roleuser.TabIndex = 26;
            this.roleuser.TextChanged += new System.EventHandler(this.roleuser_TextChanged);
            // 
            // privillable
            // 
            this.privillable.AutoSize = true;
            this.privillable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privillable.ForeColor = System.Drawing.Color.Black;
            this.privillable.Location = new System.Drawing.Point(30, 120);
            this.privillable.Name = "privillable";
            this.privillable.Size = new System.Drawing.Size(56, 18);
            this.privillable.TabIndex = 27;
            this.privillable.Text = "Quyền";
            this.privillable.Click += new System.EventHandler(this.privillable_Click);
            // 
            // tablelabel
            // 
            this.tablelabel.AutoSize = true;
            this.tablelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablelabel.ForeColor = System.Drawing.Color.Black;
            this.tablelabel.Location = new System.Drawing.Point(30, 155);
            this.tablelabel.Name = "tablelabel";
            this.tablelabel.Size = new System.Drawing.Size(46, 18);
            this.tablelabel.TabIndex = 28;
            this.tablelabel.Text = "Bảng";
            this.tablelabel.Click += new System.EventHandler(this.tablelabel_Click);
            // 
            // table
            // 
            this.table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table.Enabled = false;
            this.table.FormattingEnabled = true;
            this.table.Items.AddRange(new object[] {
            "QLDA_NHANVIEN",
            "QLDA_DEAN",
            "QLDA_PHANCONG",
            "QLDA_PHONGBAN"});
            this.table.Location = new System.Drawing.Point(173, 154);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(162, 24);
            this.table.TabIndex = 29;
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            // 
            // columnlabel
            // 
            this.columnlabel.AutoSize = true;
            this.columnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnlabel.Location = new System.Drawing.Point(372, 19);
            this.columnlabel.Name = "columnlabel";
            this.columnlabel.Size = new System.Drawing.Size(87, 18);
            this.columnlabel.TabIndex = 30;
            this.columnlabel.Text = "Thuộc tính";
            this.columnlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.columnlabel.Click += new System.EventHandler(this.columnlabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "(*) Vui lòng nhấn nút \"Kiểm tra\" bên trên để có thể cấp quyền.";
            // 
            // resetUR
            // 
            this.resetUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUR.Location = new System.Drawing.Point(264, 46);
            this.resetUR.Name = "resetUR";
            this.resetUR.Size = new System.Drawing.Size(71, 27);
            this.resetUR.TabIndex = 32;
            this.resetUR.Text = "Reset";
            this.resetUR.UseVisualStyleBackColor = true;
            this.resetUR.Click += new System.EventHandler(this.resetUR_Click);
            // 
            // GrantPrivil_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 277);
            this.ControlBox = false;
            this.Controls.Add(this.resetUR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnlabel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.tablelabel);
            this.Controls.Add(this.privillable);
            this.Controls.Add(this.roleuser);
            this.Controls.Add(this.grantButton);
            this.Controls.Add(this.column);
            this.Controls.Add(this.withgrantoption);
            this.Controls.Add(this.privil);
            this.Controls.Add(this.result);
            this.Controls.Add(this.check);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.userrolelabel);
            this.Controls.Add(this.Close);
            this.Name = "GrantPrivil_F";
            this.Text = "CẤP QUYỀN CHO ROLE/USER";
            this.Load += new System.EventHandler(this.GrantPrivil_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label userrolelabel;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox privil;
        private System.Windows.Forms.CheckBox withgrantoption;
        private System.Windows.Forms.CheckedListBox column;
        private System.Windows.Forms.Button grantButton;
        private System.Windows.Forms.TextBox roleuser;
        private System.Windows.Forms.Label privillable;
        private System.Windows.Forms.Label tablelabel;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.Label columnlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetUR;
    }
}