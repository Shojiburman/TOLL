namespace Home
{
    partial class userList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userList));
            this.userListdgv = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // userListdgv
            // 
            this.userListdgv.AllowUserToAddRows = false;
            this.userListdgv.AllowUserToDeleteRows = false;
            this.userListdgv.AllowUserToOrderColumns = true;
            this.userListdgv.AllowUserToResizeColumns = false;
            this.userListdgv.AllowUserToResizeRows = false;
            this.userListdgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userListdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userListdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userListdgv.Location = new System.Drawing.Point(-2, 0);
            this.userListdgv.MultiSelect = false;
            this.userListdgv.Name = "userListdgv";
            this.userListdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.userListdgv.Size = new System.Drawing.Size(489, 388);
            this.userListdgv.TabIndex = 19;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(182, 403);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // userList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.home);
            this.Controls.Add(this.userListdgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userList";
            this.Text = "User List";
            ((System.ComponentModel.ISupportInitialize)(this.userListdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userListdgv;
        private System.Windows.Forms.Button home;
    }
}