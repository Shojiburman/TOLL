namespace Home
{
    partial class vehicleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicleList));
            this.vehicleListdgv = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.vehicListcb = new System.Windows.Forms.ComboBox();
            this.ndftb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleListdgv
            // 
            this.vehicleListdgv.AllowUserToAddRows = false;
            this.vehicleListdgv.AllowUserToDeleteRows = false;
            this.vehicleListdgv.AllowUserToOrderColumns = true;
            this.vehicleListdgv.AllowUserToResizeColumns = false;
            this.vehicleListdgv.AllowUserToResizeRows = false;
            this.vehicleListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicleListdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vehicleListdgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vehicleListdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleListdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vehicleListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vehicleListdgv.Location = new System.Drawing.Point(-2, 1);
            this.vehicleListdgv.MultiSelect = false;
            this.vehicleListdgv.Name = "vehicleListdgv";
            this.vehicleListdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.vehicleListdgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vehicleListdgv.Size = new System.Drawing.Size(489, 388);
            this.vehicleListdgv.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(362, 407);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 16;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(228, 407);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 40);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // vehicListcb
            // 
            this.vehicListcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicListcb.FormattingEnabled = true;
            this.vehicListcb.Location = new System.Drawing.Point(13, 418);
            this.vehicListcb.Name = "vehicListcb";
            this.vehicListcb.Size = new System.Drawing.Size(209, 21);
            this.vehicListcb.TabIndex = 18;
            // 
            // ndftb
            // 
            this.ndftb.BackColor = System.Drawing.SystemColors.Control;
            this.ndftb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ndftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndftb.Location = new System.Drawing.Point(199, 174);
            this.ndftb.Name = "ndftb";
            this.ndftb.ReadOnly = true;
            this.ndftb.Size = new System.Drawing.Size(86, 14);
            this.ndftb.TabIndex = 19;
            this.ndftb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ndftb);
            this.Controls.Add(this.vehicListcb);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.home);
            this.Controls.Add(this.vehicleListdgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vehicleList";
            this.Text = "Vehicle List";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleListdgv;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox vehicListcb;
        private System.Windows.Forms.TextBox ndftb;
    }
}