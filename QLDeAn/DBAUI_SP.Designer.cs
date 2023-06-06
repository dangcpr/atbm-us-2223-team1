
namespace QLDeAn
{
    partial class DBAUI_SP
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
            this.grantView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.grantRevokeButton = new System.Windows.Forms.Button();
            this.searchGrantee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grantView)).BeginInit();
            this.SuspendLayout();
            // 
            // grantView
            // 
            this.grantView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grantView.Location = new System.Drawing.Point(32, 60);
            this.grantView.Name = "grantView";
            this.grantView.RowHeadersWidth = 51;
            this.grantView.RowTemplate.Height = 24;
            this.grantView.Size = new System.Drawing.Size(1193, 531);
            this.grantView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm Grantee";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(155, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(161, 22);
            this.searchTextBox.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(887, 17);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(130, 33);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "SELECT";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // grantRevokeButton
            // 
            this.grantRevokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRevokeButton.Location = new System.Drawing.Point(1023, 17);
            this.grantRevokeButton.Name = "grantRevokeButton";
            this.grantRevokeButton.Size = new System.Drawing.Size(202, 33);
            this.grantRevokeButton.TabIndex = 4;
            this.grantRevokeButton.Text = "GRANT/REVOKE";
            this.grantRevokeButton.UseVisualStyleBackColor = true;
            this.grantRevokeButton.Click += new System.EventHandler(this.grantRevokeButton_Click);
            // 
            // searchGrantee
            // 
            this.searchGrantee.Location = new System.Drawing.Point(323, 23);
            this.searchGrantee.Name = "searchGrantee";
            this.searchGrantee.Size = new System.Drawing.Size(87, 26);
            this.searchGrantee.TabIndex = 5;
            this.searchGrantee.Text = "Tìm kiếm";
            this.searchGrantee.UseVisualStyleBackColor = true;
            this.searchGrantee.Click += new System.EventHandler(this.searchGrantee_Click);
            // 
            // DBAUI_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchGrantee);
            this.Controls.Add(this.grantRevokeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grantView);
            this.Name = "DBAUI_SP";
            this.Size = new System.Drawing.Size(1261, 620);
            ((System.ComponentModel.ISupportInitialize)(this.grantView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grantView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button grantRevokeButton;
        private System.Windows.Forms.Button searchGrantee;
    }
}
