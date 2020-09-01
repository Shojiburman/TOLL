namespace Home
{
    partial class manageToll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageToll));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPlaceTB = new System.Windows.Forms.TextBox();
            this.newPriceTB = new System.Windows.Forms.TextBox();
            this.currentPlaceCB = new System.Windows.Forms.ComboBox();
            this.home = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.deletePlaceCB = new System.Windows.Forms.ComboBox();
            this.place = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Place";
            // 
            // newPlaceTB
            // 
            this.newPlaceTB.Location = new System.Drawing.Point(152, 58);
            this.newPlaceTB.Name = "newPlaceTB";
            this.newPlaceTB.Size = new System.Drawing.Size(228, 20);
            this.newPlaceTB.TabIndex = 3;
            // 
            // newPriceTB
            // 
            this.newPriceTB.Location = new System.Drawing.Point(152, 131);
            this.newPriceTB.Name = "newPriceTB";
            this.newPriceTB.Size = new System.Drawing.Size(228, 20);
            this.newPriceTB.TabIndex = 4;
            // 
            // currentPlaceCB
            // 
            this.currentPlaceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentPlaceCB.FormattingEnabled = true;
            this.currentPlaceCB.Location = new System.Drawing.Point(152, 95);
            this.currentPlaceCB.Name = "currentPlaceCB";
            this.currentPlaceCB.Size = new System.Drawing.Size(228, 21);
            this.currentPlaceCB.TabIndex = 5;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(152, 176);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 26;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(270, 176);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 40);
            this.update.TabIndex = 27;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // deletePlaceCB
            // 
            this.deletePlaceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deletePlaceCB.FormattingEnabled = true;
            this.deletePlaceCB.Location = new System.Drawing.Point(152, 281);
            this.deletePlaceCB.Name = "deletePlaceCB";
            this.deletePlaceCB.Size = new System.Drawing.Size(228, 21);
            this.deletePlaceCB.TabIndex = 28;
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(68, 285);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(34, 13);
            this.place.TabIndex = 29;
            this.place.Text = "Place";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(270, 327);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 40);
            this.delete.TabIndex = 30;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // manageToll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.place);
            this.Controls.Add(this.deletePlaceCB);
            this.Controls.Add(this.update);
            this.Controls.Add(this.home);
            this.Controls.Add(this.currentPlaceCB);
            this.Controls.Add(this.newPriceTB);
            this.Controls.Add(this.newPlaceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manageToll";
            this.Text = "Manage Toll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPlaceTB;
        private System.Windows.Forms.TextBox newPriceTB;
        private System.Windows.Forms.ComboBox currentPlaceCB;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox deletePlaceCB;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Button delete;
    }
}