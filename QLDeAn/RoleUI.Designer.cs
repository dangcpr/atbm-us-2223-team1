﻿
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
            // RoleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grantRole);
            this.Controls.Add(this.revokePrivilege);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoleUI";
            this.Size = new System.Drawing.Size(1261, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button revokePrivilege;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button grantRole;
    }
}
