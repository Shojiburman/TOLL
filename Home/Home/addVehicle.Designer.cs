namespace Home
{
    partial class addVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addVehicle));
            this.addVehiclebtn = new System.Windows.Forms.Button();
            this.vehicleTypeTB = new System.Windows.Forms.ComboBox();
            this.vehicleNumberTB = new System.Windows.Forms.TextBox();
            this.vehicleType = new System.Windows.Forms.Label();
            this.vehicleNumber = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehiclebtn
            // 
            this.addVehiclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addVehiclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehiclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehiclebtn.ForeColor = System.Drawing.Color.White;
            this.addVehiclebtn.Location = new System.Drawing.Point(311, 223);
            this.addVehiclebtn.Name = "addVehiclebtn";
            this.addVehiclebtn.Size = new System.Drawing.Size(110, 40);
            this.addVehiclebtn.TabIndex = 24;
            this.addVehiclebtn.Text = "Add Vehicle";
            this.addVehiclebtn.UseVisualStyleBackColor = false;
            this.addVehiclebtn.Click += new System.EventHandler(this.addVehiclebtn_Click);
            // 
            // vehicleTypeTB
            // 
            this.vehicleTypeTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleTypeTB.FormattingEnabled = true;
            this.vehicleTypeTB.Items.AddRange(new object[] {
            "BIG TRUCK",
            "MEDIEM TRUCK",
            "SMALL TRUCK",
            "BIG BUS",
            "MINIBUS",
            "MICROBUS ",
            "UTILITY ",
            "CAR ",
            "TEMPU ",
            "BEBITAXI ",
            "MOTORCYCLE ",
            "Rickshaw / VAN"});
            this.vehicleTypeTB.Location = new System.Drawing.Point(170, 156);
            this.vehicleTypeTB.Name = "vehicleTypeTB";
            this.vehicleTypeTB.Size = new System.Drawing.Size(251, 21);
            this.vehicleTypeTB.TabIndex = 21;
            // 
            // vehicleNumberTB
            // 
            this.vehicleNumberTB.Location = new System.Drawing.Point(170, 112);
            this.vehicleNumberTB.Name = "vehicleNumberTB";
            this.vehicleNumberTB.Size = new System.Drawing.Size(251, 20);
            this.vehicleNumberTB.TabIndex = 20;
            // 
            // vehicleType
            // 
            this.vehicleType.AutoSize = true;
            this.vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleType.Location = new System.Drawing.Point(64, 159);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(76, 15);
            this.vehicleType.TabIndex = 19;
            this.vehicleType.Text = "Vehicle Type";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.AutoSize = true;
            this.vehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNumber.Location = new System.Drawing.Point(64, 112);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(95, 15);
            this.vehicleNumber.TabIndex = 18;
            this.vehicleNumber.Text = "Vehicle Number";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(170, 223);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 15;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.addVehiclebtn);
            this.Controls.Add(this.vehicleTypeTB);
            this.Controls.Add(this.vehicleNumberTB);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.vehicleNumber);
            this.Controls.Add(this.home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addVehicle";
            this.Text = "Add Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVehiclebtn;
        private System.Windows.Forms.ComboBox vehicleTypeTB;
        private System.Windows.Forms.TextBox vehicleNumberTB;
        private System.Windows.Forms.Label vehicleType;
        private System.Windows.Forms.Label vehicleNumber;
        private System.Windows.Forms.Button home;
    }
}