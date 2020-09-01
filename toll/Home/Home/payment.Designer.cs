namespace Home
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.pay = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.vehicleNumber = new System.Windows.Forms.Label();
            this.placeName = new System.Windows.Forms.Label();
            this.vehicleNumberCB = new System.Windows.Forms.ComboBox();
            this.placeNameCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.White;
            this.pay.Location = new System.Drawing.Point(290, 229);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(93, 42);
            this.pay.TabIndex = 11;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(162, 229);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(93, 42);
            this.home.TabIndex = 10;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.AutoSize = true;
            this.vehicleNumber.Location = new System.Drawing.Point(74, 175);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(82, 13);
            this.vehicleNumber.TabIndex = 9;
            this.vehicleNumber.Text = "Vehicle Number";
            // 
            // placeName
            // 
            this.placeName.AutoSize = true;
            this.placeName.Location = new System.Drawing.Point(74, 123);
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(65, 13);
            this.placeName.TabIndex = 8;
            this.placeName.Text = "Place Name";
            // 
            // vehicleNumberCB
            // 
            this.vehicleNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleNumberCB.FormattingEnabled = true;
            this.vehicleNumberCB.Location = new System.Drawing.Point(162, 172);
            this.vehicleNumberCB.Name = "vehicleNumberCB";
            this.vehicleNumberCB.Size = new System.Drawing.Size(221, 21);
            this.vehicleNumberCB.TabIndex = 7;
            // 
            // placeNameCB
            // 
            this.placeNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.placeNameCB.FormattingEnabled = true;
            this.placeNameCB.Location = new System.Drawing.Point(162, 120);
            this.placeNameCB.Name = "placeNameCB";
            this.placeNameCB.Size = new System.Drawing.Size(221, 21);
            this.placeNameCB.TabIndex = 6;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.home);
            this.Controls.Add(this.vehicleNumber);
            this.Controls.Add(this.placeName);
            this.Controls.Add(this.vehicleNumberCB);
            this.Controls.Add(this.placeNameCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label vehicleNumber;
        private System.Windows.Forms.Label placeName;
        private System.Windows.Forms.ComboBox vehicleNumberCB;
        private System.Windows.Forms.ComboBox placeNameCB;
    }
}