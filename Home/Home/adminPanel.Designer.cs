namespace Home
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.untextbox = new System.Windows.Forms.TextBox();
            this.addToll = new System.Windows.Forms.Button();
            this.tollList = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.Button();
            this.transactionList = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.manageToll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // untextbox
            // 
            this.untextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.untextbox.BackColor = System.Drawing.SystemColors.Control;
            this.untextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.untextbox.Location = new System.Drawing.Point(78, 22);
            this.untextbox.Multiline = true;
            this.untextbox.Name = "untextbox";
            this.untextbox.ReadOnly = true;
            this.untextbox.Size = new System.Drawing.Size(332, 20);
            this.untextbox.TabIndex = 29;
            // 
            // addToll
            // 
            this.addToll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addToll.Location = new System.Drawing.Point(77, 67);
            this.addToll.Name = "addToll";
            this.addToll.Size = new System.Drawing.Size(332, 39);
            this.addToll.TabIndex = 31;
            this.addToll.Text = "Add Toll";
            this.addToll.UseVisualStyleBackColor = false;
            this.addToll.Click += new System.EventHandler(this.addToll_Click);
            // 
            // tollList
            // 
            this.tollList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tollList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tollList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tollList.Location = new System.Drawing.Point(77, 181);
            this.tollList.Name = "tollList";
            this.tollList.Size = new System.Drawing.Size(332, 39);
            this.tollList.TabIndex = 33;
            this.tollList.Text = "Toll List";
            this.tollList.UseVisualStyleBackColor = false;
            this.tollList.Click += new System.EventHandler(this.tollList_Click);
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userList.Location = new System.Drawing.Point(77, 236);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(332, 39);
            this.userList.TabIndex = 34;
            this.userList.Text = "User List";
            this.userList.UseVisualStyleBackColor = false;
            this.userList.Click += new System.EventHandler(this.userList_Click);
            // 
            // transactionList
            // 
            this.transactionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionList.Location = new System.Drawing.Point(77, 293);
            this.transactionList.Name = "transactionList";
            this.transactionList.Size = new System.Drawing.Size(332, 39);
            this.transactionList.TabIndex = 35;
            this.transactionList.Text = "Transaction List";
            this.transactionList.UseVisualStyleBackColor = false;
            this.transactionList.Click += new System.EventHandler(this.transactionList_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.Location = new System.Drawing.Point(77, 351);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(332, 39);
            this.logout.TabIndex = 36;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // manageToll
            // 
            this.manageToll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageToll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageToll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manageToll.Location = new System.Drawing.Point(77, 124);
            this.manageToll.Name = "manageToll";
            this.manageToll.Size = new System.Drawing.Size(332, 39);
            this.manageToll.TabIndex = 37;
            this.manageToll.Text = "Manage Toll";
            this.manageToll.UseVisualStyleBackColor = false;
            this.manageToll.Click += new System.EventHandler(this.manageToll_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.manageToll);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.transactionList);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.tollList);
            this.Controls.Add(this.addToll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.untextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox untextbox;
        private System.Windows.Forms.Button addToll;
        private System.Windows.Forms.Button tollList;
        private System.Windows.Forms.Button userList;
        private System.Windows.Forms.Button transactionList;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button manageToll;
    }
}