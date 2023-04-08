
namespace QLDeAn
{
    partial class RevokeRole_F
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
            this.user = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.TextBox();
            this.revokeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userrolelabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(281, 33);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(162, 24);
            this.user.TabIndex = 41;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(281, 76);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(162, 24);
            this.role.TabIndex = 40;
            this.role.TextChanged += new System.EventHandler(this.role_TextChanged);
            // 
            // revokeButton
            // 
            this.revokeButton.Location = new System.Drawing.Point(233, 137);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(162, 33);
            this.revokeButton.TabIndex = 39;
            this.revokeButton.Text = "Thu hồi Role";
            this.revokeButton.UseVisualStyleBackColor = true;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Role muốn thu hồi";
            // 
            // userrolelabel
            // 
            this.userrolelabel.AutoSize = true;
            this.userrolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrolelabel.ForeColor = System.Drawing.Color.Black;
            this.userrolelabel.Location = new System.Drawing.Point(50, 36);
            this.userrolelabel.Name = "userrolelabel";
            this.userrolelabel.Size = new System.Drawing.Size(132, 18);
            this.userrolelabel.TabIndex = 37;
            this.userrolelabel.Text = "User cần thu hồi";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(401, 137);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 36;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // RevokeRole_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 195);
            this.ControlBox = false;
            this.Controls.Add(this.user);
            this.Controls.Add(this.role);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userrolelabel);
            this.Controls.Add(this.Close);
            this.Name = "RevokeRole_F";
            this.Text = "RevokeRole_F";
            this.Load += new System.EventHandler(this.RevokeRole_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userrolelabel;
        private System.Windows.Forms.Button Close;
    }
}