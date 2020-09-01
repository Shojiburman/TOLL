namespace Home
{
    partial class tollList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tollList));
            this.home = new System.Windows.Forms.Button();
            this.tollListdgv = new System.Windows.Forms.DataGridView();
            this.ndftb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tollListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(178, 403);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 17;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // tollListdgv
            // 
            this.tollListdgv.AllowUserToAddRows = false;
            this.tollListdgv.AllowUserToDeleteRows = false;
            this.tollListdgv.AllowUserToOrderColumns = true;
            this.tollListdgv.AllowUserToResizeColumns = false;
            this.tollListdgv.AllowUserToResizeRows = false;
            this.tollListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tollListdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tollListdgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tollListdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tollListdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tollListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tollListdgv.Location = new System.Drawing.Point(-2, 1);
            this.tollListdgv.MultiSelect = false;
            this.tollListdgv.Name = "tollListdgv";
            this.tollListdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tollListdgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tollListdgv.Size = new System.Drawing.Size(489, 388);
            this.tollListdgv.TabIndex = 18;
            // 
            // ndftb
            // 
            this.ndftb.BackColor = System.Drawing.SystemColors.Control;
            this.ndftb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ndftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndftb.Location = new System.Drawing.Point(199, 178);
            this.ndftb.Name = "ndftb";
            this.ndftb.ReadOnly = true;
            this.ndftb.Size = new System.Drawing.Size(86, 14);
            this.ndftb.TabIndex = 22;
            // 
            // tollList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ndftb);
            this.Controls.Add(this.tollListdgv);
            this.Controls.Add(this.home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tollList";
            this.Text = "Toll List";
            ((System.ComponentModel.ISupportInitialize)(this.tollListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.DataGridView tollListdgv;
        private System.Windows.Forms.TextBox ndftb;
    }
}