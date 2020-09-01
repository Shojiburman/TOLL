namespace payment
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
            this.placeNameCB = new System.Windows.Forms.ComboBox();
            this.vehicleNumberCB = new System.Windows.Forms.ComboBox();
            this.placeName = new System.Windows.Forms.Label();
            this.vehicleNumber = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeNameCB
            // 
            this.placeNameCB.FormattingEnabled = true;
            this.placeNameCB.Location = new System.Drawing.Point(166, 138);
            this.placeNameCB.Name = "placeNameCB";
            this.placeNameCB.Size = new System.Drawing.Size(221, 21);
            this.placeNameCB.TabIndex = 0;
            // 
            // vehicleNumberCB
            // 
            this.vehicleNumberCB.FormattingEnabled = true;
            this.vehicleNumberCB.Location = new System.Drawing.Point(166, 190);
            this.vehicleNumberCB.Name = "vehicleNumberCB";
            this.vehicleNumberCB.Size = new System.Drawing.Size(221, 21);
            this.vehicleNumberCB.TabIndex = 1;
            // 
            // placeName
            // 
            this.placeName.AutoSize = true;
            this.placeName.Location = new System.Drawing.Point(78, 141);
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(65, 13);
            this.placeName.TabIndex = 2;
            this.placeName.Text = "Place Name";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.AutoSize = true;
            this.vehicleNumber.Location = new System.Drawing.Point(78, 193);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(82, 13);
            this.vehicleNumber.TabIndex = 3;
            this.vehicleNumber.Text = "Vehicle Number";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(166, 247);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(93, 42);
            this.home.TabIndex = 4;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.White;
            this.pay.Location = new System.Drawing.Point(294, 247);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(93, 42);
            this.pay.TabIndex = 5;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
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

        private System.Windows.Forms.ComboBox placeNameCB;
        private System.Windows.Forms.ComboBox vehicleNumberCB;
        private System.Windows.Forms.Label placeName;
        private System.Windows.Forms.Label vehicleNumber;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button pay;
    }
}

