
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUserRole = new System.Windows.Forms.TabPage();
            this.tabPrivilege = new System.Windows.Forms.TabPage();
            this.tabTableView = new System.Windows.Forms.TabPage();
            this.tabSystemPrivilege = new System.Windows.Forms.TabPage();
            this.auditTab = new System.Windows.Forms.TabPage();
            this.userAndRoleUI1 = new QLDeAn.UserAndRoleUI();
            this.privilegeUI1 = new QLDeAn.PrivilegeUI();
            this.roleUI1 = new QLDeAn.RoleUI();
            this.dbauI_TableView1 = new QLDeAn.DBAUI_TableView();
            this.dbA_SP1 = new QLDeAn.DBAUI_SP();
            this.dbA_Audit1 = new QLDeAn.DBA_Audit();
            this.tabRole.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabUserRole.SuspendLayout();
            this.tabPrivilege.SuspendLayout();
            this.tabTableView.SuspendLayout();
            this.tabSystemPrivilege.SuspendLayout();
            this.auditTab.SuspendLayout();
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
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1206, 667);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 1;
            this.Close.Text = "ĐÓNG";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(997, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "XIN CHÀO";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUserRole);
            this.tabControl.Controls.Add(this.tabPrivilege);
            this.tabControl.Controls.Add(this.tabRole);
            this.tabControl.Controls.Add(this.tabTableView);
            this.tabControl.Controls.Add(this.tabSystemPrivilege);
            this.tabControl.Controls.Add(this.auditTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1269, 649);
            this.tabControl.TabIndex = 2;
            // 
            // tabUserRole
            // 
            this.tabUserRole.Controls.Add(this.userAndRoleUI1);
            this.tabUserRole.Location = new System.Drawing.Point(4, 25);
            this.tabUserRole.Name = "tabUserRole";
            this.tabUserRole.Size = new System.Drawing.Size(1261, 620);
            this.tabUserRole.TabIndex = 4;
            this.tabUserRole.Text = "User & Role";
            this.tabUserRole.UseVisualStyleBackColor = true;
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
            this.tabPrivilege.Click += new System.EventHandler(this.tabPrivilege_Click);
            // 
            // tabTableView
            // 
            this.tabTableView.Controls.Add(this.dbauI_TableView1);
            this.tabTableView.Location = new System.Drawing.Point(4, 25);
            this.tabTableView.Name = "tabTableView";
            this.tabTableView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableView.Size = new System.Drawing.Size(1261, 620);
            this.tabTableView.TabIndex = 3;
            this.tabTableView.Text = "Table & View";
            this.tabTableView.UseVisualStyleBackColor = true;
            // 
            // tabSystemPrivilege
            // 
            this.tabSystemPrivilege.Controls.Add(this.dbA_SP1);
            this.tabSystemPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tabSystemPrivilege.Name = "tabSystemPrivilege";
            this.tabSystemPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemPrivilege.Size = new System.Drawing.Size(1261, 620);
            this.tabSystemPrivilege.TabIndex = 5;
            this.tabSystemPrivilege.Text = "System Privilege";
            this.tabSystemPrivilege.UseVisualStyleBackColor = true;
            // 
            // auditTab
            // 
            this.auditTab.Controls.Add(this.dbA_Audit1);
            this.auditTab.Location = new System.Drawing.Point(4, 25);
            this.auditTab.Name = "auditTab";
            this.auditTab.Padding = new System.Windows.Forms.Padding(3);
            this.auditTab.Size = new System.Drawing.Size(1261, 620);
            this.auditTab.TabIndex = 6;
            this.auditTab.Text = "Audit";
            this.auditTab.UseVisualStyleBackColor = true;
            // 
            // userAndRoleUI1
            // 
            this.userAndRoleUI1.Location = new System.Drawing.Point(4, 4);
            this.userAndRoleUI1.Name = "userAndRoleUI1";
            this.userAndRoleUI1.Size = new System.Drawing.Size(1261, 620);
            this.userAndRoleUI1.TabIndex = 0;
            // 
            // privilegeUI1
            // 
            this.privilegeUI1.Location = new System.Drawing.Point(-3, 0);
            this.privilegeUI1.Name = "privilegeUI1";
            this.privilegeUI1.Size = new System.Drawing.Size(1261, 620);
            this.privilegeUI1.TabIndex = 0;
            // 
            // roleUI1
            // 
            this.roleUI1.Location = new System.Drawing.Point(-3, 0);
            this.roleUI1.Name = "roleUI1";
            this.roleUI1.Size = new System.Drawing.Size(1261, 620);
            this.roleUI1.TabIndex = 0;
            // 
            // dbauI_TableView1
            // 
            this.dbauI_TableView1.Location = new System.Drawing.Point(-4, 0);
            this.dbauI_TableView1.Name = "dbauI_TableView1";
            this.dbauI_TableView1.Size = new System.Drawing.Size(1261, 620);
            this.dbauI_TableView1.TabIndex = 0;
            // 
            // dbA_SP1
            // 
            this.dbA_SP1.Location = new System.Drawing.Point(0, 0);
            this.dbA_SP1.Name = "dbA_SP1";
            this.dbA_SP1.Size = new System.Drawing.Size(1261, 620);
            this.dbA_SP1.TabIndex = 0;
            // 
            // dbA_Audit1
            // 
            this.dbA_Audit1.Location = new System.Drawing.Point(0, 0);
            this.dbA_Audit1.Name = "dbA_Audit1";
            this.dbA_Audit1.Size = new System.Drawing.Size(1261, 620);
            this.dbA_Audit1.TabIndex = 0;
            // 
            // DBAUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 712);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.tabControl);
            this.Name = "DBAUI";
            this.Text = "QUẢN TRỊ VIÊN";
            this.Load += new System.EventHandler(this.DBAUI_Load);
            this.tabRole.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabUserRole.ResumeLayout(false);
            this.tabPrivilege.ResumeLayout(false);
            this.tabTableView.ResumeLayout(false);
            this.tabSystemPrivilege.ResumeLayout(false);
            this.auditTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPrivilege;
        private System.Windows.Forms.TabPage tabTableView;
        private System.Windows.Forms.TabPage tabUserRole;
        private UserAndRoleUI userAndRoleUI1;
        private PrivilegeUI privilegeUI1;
        private RoleUI roleUI1;
        private DBAUI_TableView dbauI_TableView1;
        private System.Windows.Forms.TabPage tabSystemPrivilege;
        private DBAUI_SP dbA_SP1;
        private System.Windows.Forms.TabPage auditTab;
        private DBA_Audit dbA_Audit1;
    }
}