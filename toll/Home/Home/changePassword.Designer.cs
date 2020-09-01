namespace Home
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
            this.update = new System.Windows.Forms.Button();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Label();
            this.currentPasswordTB = new System.Windows.Forms.TextBox();
            this.currentPassword = new System.Windows.Forms.Label();
            this.hone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(301, 227);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 43);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTB.Location = new System.Drawing.Point(182, 150);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.PasswordChar = '*';
            this.newPasswordTB.Size = new System.Drawing.Size(209, 23);
            this.newPasswordTB.TabIndex = 14;
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTB.Location = new System.Drawing.Point(182, 186);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.PasswordChar = '*';
            this.confirmPasswordTB.Size = new System.Drawing.Size(209, 21);
            this.confirmPasswordTB.TabIndex = 13;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(86, 188);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(91, 13);
            this.confirmPassword.TabIndex = 12;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Location = new System.Drawing.Point(86, 154);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(78, 13);
            this.newPassword.TabIndex = 11;
            this.newPassword.Text = "New Password";
            // 
            // currentPasswordTB
            // 
            this.currentPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTB.Location = new System.Drawing.Point(182, 114);
            this.currentPasswordTB.Name = "currentPasswordTB";
            this.currentPasswordTB.PasswordChar = '*';
            this.currentPasswordTB.Size = new System.Drawing.Size(209, 21);
            this.currentPasswordTB.TabIndex = 10;
            // 
            // currentPassword
            // 
            this.currentPassword.AutoSize = true;
            this.currentPassword.Location = new System.Drawing.Point(86, 117);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(90, 13);
            this.currentPassword.TabIndex = 9;
            this.currentPassword.Text = "Current Password";
            // 
            // hone
            // 
            this.hone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hone.ForeColor = System.Drawing.Color.White;
            this.hone.Location = new System.Drawing.Point(182, 227);
            this.hone.Name = "hone";
            this.hone.Size = new System.Drawing.Size(90, 43);
            this.hone.TabIndex = 8;
            this.hone.Text = "Home";
            this.hone.UseVisualStyleBackColor = false;
            this.hone.Click += new System.EventHandler(this.hone_Click);
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

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox currentPasswordTB;
        private System.Windows.Forms.Label currentPassword;
        private System.Windows.Forms.Button hone;
    }
}