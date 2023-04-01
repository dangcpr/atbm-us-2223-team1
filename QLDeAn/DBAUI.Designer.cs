
namespace QLDeAn
{
    partial class DBAUI
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
            this.logout = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUserARole = new System.Windows.Forms.TabPage();
            this.userAndRoleUI1 = new QLDeAn.UserAndRoleUI();
            this.tabPrivilege = new System.Windows.Forms.TabPage();
            this.privilegeUI1 = new QLDeAn.PrivilegeUI();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.roleUI1 = new QLDeAn.RoleUI();
            this.Reset = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabUserARole.SuspendLayout();
            this.tabPrivilege.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1158, 7);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(121, 28);
            this.logout.TabIndex = 0;
            this.logout.Text = "ĐĂNG XUẤT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1206, 667);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUserARole);
            this.tabControl.Controls.Add(this.tabPrivilege);
            this.tabControl.Controls.Add(this.tabRole);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1269, 649);
            this.tabControl.TabIndex = 2;
            // 
            // tabUserARole
            // 
            this.tabUserARole.Controls.Add(this.userAndRoleUI1);
            this.tabUserARole.Location = new System.Drawing.Point(4, 25);
            this.tabUserARole.Name = "tabUserARole";
            this.tabUserARole.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserARole.Size = new System.Drawing.Size(1261, 620);
            this.tabUserARole.TabIndex = 0;
            this.tabUserARole.Text = "User & Roles";
            this.tabUserARole.UseVisualStyleBackColor = true;
            this.tabUserARole.Click += new System.EventHandler(this.tabUserARole_Click);
            // 
            // userAndRoleUI1
            // 
            this.userAndRoleUI1.Location = new System.Drawing.Point(0, 0);
            this.userAndRoleUI1.Name = "userAndRoleUI1";
            this.userAndRoleUI1.Size = new System.Drawing.Size(1261, 620);
            this.userAndRoleUI1.TabIndex = 2;
            this.userAndRoleUI1.Load += new System.EventHandler(this.userAndRoleUI1_Load);
            // 
            // tabPrivilege
            // 
            this.tabPrivilege.Controls.Add(this.privilegeUI1);
            this.tabPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tabPrivilege.Name = "tabPrivilege";
            this.tabPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrivilege.Size = new System.Drawing.Size(1261, 620);
            this.tabPrivilege.TabIndex = 1;
            this.tabPrivilege.Text = "Privilege";
            this.tabPrivilege.UseVisualStyleBackColor = true;
            // 
            // privilegeUI1
            // 
            this.privilegeUI1.Location = new System.Drawing.Point(0, 0);
            this.privilegeUI1.Name = "privilegeUI1";
            this.privilegeUI1.Size = new System.Drawing.Size(1261, 620);
            this.privilegeUI1.TabIndex = 0;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.roleUI1);
            this.tabRole.Location = new System.Drawing.Point(4, 25);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(1261, 620);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // roleUI1
            // 
            this.roleUI1.Location = new System.Drawing.Point(0, 0);
            this.roleUI1.Name = "roleUI1";
            this.roleUI1.Size = new System.Drawing.Size(1261, 620);
            this.roleUI1.TabIndex = 0;
            this.roleUI1.Load += new System.EventHandler(this.roleUI1_Load);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(1112, 667);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 33);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DBAUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 712);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.tabControl);
            this.Name = "DBAUI";
            this.Text = "QUẢN TRỊ VIÊN";
            this.Load += new System.EventHandler(this.DBAUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUserARole.ResumeLayout(false);
            this.tabPrivilege.ResumeLayout(false);
            this.tabRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUserARole;
        private System.Windows.Forms.TabPage tabPrivilege;
        private System.Windows.Forms.TabPage tabRole;
        private UserAndRoleUI userAndRoleUI1;
        private PrivilegeUI privilegeUI1;
        private RoleUI roleUI1;
        private System.Windows.Forms.Button Reset;
    }
}