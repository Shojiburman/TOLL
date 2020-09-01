namespace Home
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.tollCS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tollCS
            // 
            this.tollCS.AutoSize = true;
            this.tollCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tollCS.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tollCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tollCS.Location = new System.Drawing.Point(113, 55);
            this.tollCS.Name = "tollCS";
            this.tollCS.Size = new System.Drawing.Size(240, 26);
            this.tollCS.TabIndex = 0;
            this.tollCS.Text = "Toll Collection System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(47, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOIN NOW";
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup.Location = new System.Drawing.Point(50, 167);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(378, 47);
            this.Signup.TabIndex = 2;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log_in.Location = new System.Drawing.Point(50, 266);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(378, 47);
            this.log_in.TabIndex = 3;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(214, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "OR";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tollCS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tollCS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Label label2;
    }
}

