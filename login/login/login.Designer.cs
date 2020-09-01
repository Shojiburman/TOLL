namespace login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.unerror = new System.Windows.Forms.Label();
            this.passerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(165, 119);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(220, 20);
            this.usernametb.TabIndex = 1;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homebtn.Location = new System.Drawing.Point(165, 210);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(96, 39);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(165, 165);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(220, 20);
            this.passwordtb.TabIndex = 4;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(289, 210);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(96, 39);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupbtn.Location = new System.Drawing.Point(220, 297);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(96, 39);
            this.signupbtn.TabIndex = 6;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t Have an Account?";
            // 
            // unerror
            // 
            this.unerror.AutoSize = true;
            this.unerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unerror.ForeColor = System.Drawing.Color.Red;
            this.unerror.Location = new System.Drawing.Point(185, 137);
            this.unerror.Name = "unerror";
            this.unerror.Size = new System.Drawing.Size(184, 15);
            this.unerror.TabIndex = 8;
            this.unerror.Text = "The User Name field is required.";
            this.unerror.Visible = false;
            // 
            // passerror
            // 
            this.passerror.AutoSize = true;
            this.passerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passerror.ForeColor = System.Drawing.Color.Red;
            this.passerror.Location = new System.Drawing.Point(189, 183);
            this.passerror.Name = "passerror";
            this.passerror.Size = new System.Drawing.Size(175, 15);
            this.passerror.TabIndex = 9;
            this.passerror.Text = "The Password field is required.";
            this.passerror.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unerror);
            this.Controls.Add(this.passerror);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label unerror;
        private System.Windows.Forms.Label passerror;
    }
}

