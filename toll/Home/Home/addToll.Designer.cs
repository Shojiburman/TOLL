namespace Home
{
    partial class addToll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addToll));
            this.addTollbtn = new System.Windows.Forms.Button();
            this.placeTB = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTollbtn
            // 
            this.addTollbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTollbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTollbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTollbtn.ForeColor = System.Drawing.Color.White;
            this.addTollbtn.Location = new System.Drawing.Point(307, 214);
            this.addTollbtn.Name = "addTollbtn";
            this.addTollbtn.Size = new System.Drawing.Size(110, 40);
            this.addTollbtn.TabIndex = 30;
            this.addTollbtn.Text = "Add Toll";
            this.addTollbtn.UseVisualStyleBackColor = false;
            this.addTollbtn.Click += new System.EventHandler(this.addTollbtn_Click);
            // 
            // placeTB
            // 
            this.placeTB.Location = new System.Drawing.Point(166, 103);
            this.placeTB.Name = "placeTB";
            this.placeTB.Size = new System.Drawing.Size(251, 20);
            this.placeTB.TabIndex = 28;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(60, 150);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 15);
            this.price.TabIndex = 27;
            this.price.Text = "Price";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place.Location = new System.Drawing.Point(60, 103);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(38, 15);
            this.place.TabIndex = 26;
            this.place.Text = "Place";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(166, 214);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 25;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(166, 149);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(251, 20);
            this.priceTB.TabIndex = 31;
            // 
            // addToll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.addTollbtn);
            this.Controls.Add(this.placeTB);
            this.Controls.Add(this.price);
            this.Controls.Add(this.place);
            this.Controls.Add(this.home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addToll";
            this.Text = "Add Toll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTollbtn;
        private System.Windows.Forms.TextBox placeTB;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox priceTB;
    }
}