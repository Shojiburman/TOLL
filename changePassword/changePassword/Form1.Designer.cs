namespace changePassword
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.hone = new System.Windows.Forms.Button();
            this.currentPassword = new System.Windows.Forms.Label();
            this.currentPasswordTB = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hone
            // 
            this.hone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hone.ForeColor = System.Drawing.Color.White;
            this.hone.Location = new System.Drawing.Point(179, 221);
            this.hone.Name = "hone";
            this.hone.Size = new System.Drawing.Size(90, 43);
            this.hone.TabIndex = 0;
            this.hone.Text = "Home";
            this.hone.UseVisualStyleBackColor = false;
            // 
            // currentPassword
            // 
            this.currentPassword.AutoSize = true;
            this.currentPassword.Location = new System.Drawing.Point(83, 111);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(90, 13);
            this.currentPassword.TabIndex = 1;
            this.currentPassword.Text = "Current Password";
            // 
            // currentPasswordTB
            // 
            this.currentPasswordTB.Location = new System.Drawing.Point(179, 108);
            this.currentPasswordTB.Name = "currentPasswordTB";
            this.currentPasswordTB.Size = new System.Drawing.Size(209, 20);
            this.currentPasswordTB.TabIndex = 2;
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Location = new System.Drawing.Point(83, 148);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(78, 13);
            this.newPassword.TabIndex = 3;
            this.newPassword.Text = "New Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(83, 182);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(91, 13);
            this.confirmPassword.TabIndex = 4;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Location = new System.Drawing.Point(179, 180);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(209, 20);
            this.confirmPasswordTB.TabIndex = 5;
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Location = new System.Drawing.Point(179, 144);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(209, 20);
            this.newPasswordTB.TabIndex = 6;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(298, 221);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 43);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newPasswordTB);
            this.Controls.Add(this.confirmPasswordTB);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.currentPasswordTB);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.hone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hone;
        private System.Windows.Forms.Label currentPassword;
        private System.Windows.Forms.TextBox currentPasswordTB;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.Button update;
    }
}

