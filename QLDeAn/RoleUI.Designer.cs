
namespace QLDeAn
{
    partial class RoleUI
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
            this.revokePrivilege = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grantRole = new System.Windows.Forms.Button();
            this.textFU = new System.Windows.Forms.TextBox();
            this.label_findU = new System.Windows.Forms.Label();
            this.findU = new System.Windows.Forms.Button();
            this.findR = new System.Windows.Forms.Button();
            this.labelFR = new System.Windows.Forms.Label();
            this.textFR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // revokePrivilege
            // 
            this.revokePrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokePrivilege.Location = new System.Drawing.Point(208, 12);
            this.revokePrivilege.Name = "revokePrivilege";
            this.revokePrivilege.Size = new System.Drawing.Size(172, 42);
            this.revokePrivilege.TabIndex = 8;
            this.revokePrivilege.Text = "HỦY ROLE CỦA USER";
            this.revokePrivilege.UseCompatibleTextRendering = true;
            this.revokePrivilege.UseVisualStyleBackColor = true;
            this.revokePrivilege.Click += new System.EventHandler(this.revokePrivilege_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 537);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // grantRole
            // 
            this.grantRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRole.Location = new System.Drawing.Point(30, 12);
            this.grantRole.Name = "grantRole";
            this.grantRole.Size = new System.Drawing.Size(172, 42);
            this.grantRole.TabIndex = 9;
            this.grantRole.Text = "CẤP ROLE CHO USER";
            this.grantRole.UseCompatibleTextRendering = true;
            this.grantRole.UseVisualStyleBackColor = true;
            this.grantRole.Click += new System.EventHandler(this.grantRole_Click);
            // 
            // textFU
            // 
            this.textFU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFU.Location = new System.Drawing.Point(402, 27);
            this.textFU.Name = "textFU";
            this.textFU.Size = new System.Drawing.Size(152, 27);
            this.textFU.TabIndex = 10;
            this.textFU.TextChanged += new System.EventHandler(this.textFU_TextChanged);
            // 
            // label_findU
            // 
            this.label_findU.AutoSize = true;
            this.label_findU.Location = new System.Drawing.Point(399, 12);
            this.label_findU.Name = "label_findU";
            this.label_findU.Size = new System.Drawing.Size(98, 17);
            this.label_findU.TabIndex = 12;
            this.label_findU.Text = "Tìm kiếm User";
            // 
            // findU
            // 
            this.findU.Location = new System.Drawing.Point(560, 28);
            this.findU.Name = "findU";
            this.findU.Size = new System.Drawing.Size(87, 27);
            this.findU.TabIndex = 13;
            this.findU.Text = "Tìm kiếm";
            this.findU.UseVisualStyleBackColor = true;
            this.findU.Click += new System.EventHandler(this.findU_Click);
            // 
            // findR
            // 
            this.findR.Location = new System.Drawing.Point(846, 27);
            this.findR.Name = "findR";
            this.findR.Size = new System.Drawing.Size(87, 27);
            this.findR.TabIndex = 22;
            this.findR.Text = "Tìm kiếm";
            this.findR.UseVisualStyleBackColor = true;
            this.findR.Click += new System.EventHandler(this.findR_Click);
            // 
            // labelFR
            // 
            this.labelFR.AutoSize = true;
            this.labelFR.Location = new System.Drawing.Point(685, 12);
            this.labelFR.Name = "labelFR";
            this.labelFR.Size = new System.Drawing.Size(97, 17);
            this.labelFR.TabIndex = 21;
            this.labelFR.Text = "Tìm kiếm Role";
            // 
            // textFR
            // 
            this.textFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFR.Location = new System.Drawing.Point(688, 27);
            this.textFR.Name = "textFR";
            this.textFR.Size = new System.Drawing.Size(152, 27);
            this.textFR.TabIndex = 23;
            this.textFR.TextChanged += new System.EventHandler(this.textFR_TextChanged);
            // 
            // RoleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textFR);
            this.Controls.Add(this.findR);
            this.Controls.Add(this.labelFR);
            this.Controls.Add(this.findU);
            this.Controls.Add(this.label_findU);
            this.Controls.Add(this.textFU);
            this.Controls.Add(this.grantRole);
            this.Controls.Add(this.revokePrivilege);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoleUI";
            this.Size = new System.Drawing.Size(1261, 620);
            this.Load += new System.EventHandler(this.RoleUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revokePrivilege;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button grantRole;
        private System.Windows.Forms.TextBox textFU;
        private System.Windows.Forms.Label label_findU;
        private System.Windows.Forms.Button findU;
        private System.Windows.Forms.Button findR;
        private System.Windows.Forms.Label labelFR;
        private System.Windows.Forms.TextBox textFR;
    }
}
