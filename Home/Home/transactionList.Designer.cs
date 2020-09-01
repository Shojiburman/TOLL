namespace Home
{
    partial class transactionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionList));
            this.transactionListdgv = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            this.ndftb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionListdgv
            // 
            this.transactionListdgv.AllowUserToAddRows = false;
            this.transactionListdgv.AllowUserToDeleteRows = false;
            this.transactionListdgv.AllowUserToOrderColumns = true;
            this.transactionListdgv.AllowUserToResizeColumns = false;
            this.transactionListdgv.AllowUserToResizeRows = false;
            this.transactionListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionListdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactionListdgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transactionListdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionListdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transactionListdgv.Location = new System.Drawing.Point(-2, 0);
            this.transactionListdgv.MultiSelect = false;
            this.transactionListdgv.Name = "transactionListdgv";
            this.transactionListdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.transactionListdgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transactionListdgv.Size = new System.Drawing.Size(489, 388);
            this.transactionListdgv.TabIndex = 19;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(186, 404);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // ndftb
            // 
            this.ndftb.BackColor = System.Drawing.SystemColors.Control;
            this.ndftb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ndftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndftb.Location = new System.Drawing.Point(199, 181);
            this.ndftb.Name = "ndftb";
            this.ndftb.ReadOnly = true;
            this.ndftb.Size = new System.Drawing.Size(86, 14);
            this.ndftb.TabIndex = 21;
            // 
            // transactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ndftb);
            this.Controls.Add(this.home);
            this.Controls.Add(this.transactionListdgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transactionList";
            this.Text = "Transaction List";
            ((System.ComponentModel.ISupportInitialize)(this.transactionListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionListdgv;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox ndftb;
    }
}