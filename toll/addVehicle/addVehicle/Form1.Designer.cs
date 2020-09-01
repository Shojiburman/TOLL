namespace addVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleModelTB = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.brandnameCB = new System.Windows.Forms.ComboBox();
            this.vehicleModel = new System.Windows.Forms.Label();
            this.vehicleNumber = new System.Windows.Forms.Label();
            this.vehicleType = new System.Windows.Forms.Label();
            this.vehicleNumberTB = new System.Windows.Forms.TextBox();
            this.vehicleTypeCB = new System.Windows.Forms.ComboBox();
            this.vehicleClass = new System.Windows.Forms.Label();
            this.vehicleClassCB = new System.Windows.Forms.ComboBox();
            this.addVehiclebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Name";
            // 
            // vehicleModelTB
            // 
            this.vehicleModelTB.Location = new System.Drawing.Point(164, 99);
            this.vehicleModelTB.Name = "vehicleModelTB";
            this.vehicleModelTB.Size = new System.Drawing.Size(251, 20);
            this.vehicleModelTB.TabIndex = 1;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(164, 280);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 40);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            // 
            // brandnameCB
            // 
            this.brandnameCB.DisplayMember = "--Select--";
            this.brandnameCB.FormattingEnabled = true;
            this.brandnameCB.Items.AddRange(new object[] {
            "select",
            "select",
            "select",
            "select"});
            this.brandnameCB.Location = new System.Drawing.Point(164, 51);
            this.brandnameCB.Name = "brandnameCB";
            this.brandnameCB.Size = new System.Drawing.Size(251, 21);
            this.brandnameCB.Sorted = true;
            this.brandnameCB.TabIndex = 3;
            this.brandnameCB.Tag = "";
            // 
            // vehicleModel
            // 
            this.vehicleModel.AutoSize = true;
            this.vehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleModel.Location = new System.Drawing.Point(58, 101);
            this.vehicleModel.Name = "vehicleModel";
            this.vehicleModel.Size = new System.Drawing.Size(85, 15);
            this.vehicleModel.TabIndex = 4;
            this.vehicleModel.Text = "Vehicle Model";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.AutoSize = true;
            this.vehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNumber.Location = new System.Drawing.Point(58, 144);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(95, 15);
            this.vehicleNumber.TabIndex = 5;
            this.vehicleNumber.Text = "Vehicle Number";
            // 
            // vehicleType
            // 
            this.vehicleType.AutoSize = true;
            this.vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleType.Location = new System.Drawing.Point(58, 235);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(76, 15);
            this.vehicleType.TabIndex = 6;
            this.vehicleType.Text = "Vehicle Type";
            // 
            // vehicleNumberTB
            // 
            this.vehicleNumberTB.Location = new System.Drawing.Point(164, 144);
            this.vehicleNumberTB.Name = "vehicleNumberTB";
            this.vehicleNumberTB.Size = new System.Drawing.Size(251, 20);
            this.vehicleNumberTB.TabIndex = 7;
            // 
            // vehicleTypeCB
            // 
            this.vehicleTypeCB.FormattingEnabled = true;
            this.vehicleTypeCB.Items.AddRange(new object[] {
            "select",
            "select",
            "select",
            "select"});
            this.vehicleTypeCB.Location = new System.Drawing.Point(164, 232);
            this.vehicleTypeCB.Name = "vehicleTypeCB";
            this.vehicleTypeCB.Size = new System.Drawing.Size(251, 21);
            this.vehicleTypeCB.TabIndex = 9;
            // 
            // vehicleClass
            // 
            this.vehicleClass.AutoSize = true;
            this.vehicleClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleClass.Location = new System.Drawing.Point(58, 187);
            this.vehicleClass.Name = "vehicleClass";
            this.vehicleClass.Size = new System.Drawing.Size(80, 15);
            this.vehicleClass.TabIndex = 10;
            this.vehicleClass.Text = "Vehicle Class";
            // 
            // vehicleClassCB
            // 
            this.vehicleClassCB.FormattingEnabled = true;
            this.vehicleClassCB.Items.AddRange(new object[] {
            "select",
            "select",
            "select",
            "select"});
            this.vehicleClassCB.Location = new System.Drawing.Point(164, 185);
            this.vehicleClassCB.Name = "vehicleClassCB";
            this.vehicleClassCB.Size = new System.Drawing.Size(251, 21);
            this.vehicleClassCB.TabIndex = 11;
            // 
            // addVehiclebtn
            // 
            this.addVehiclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addVehiclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehiclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehiclebtn.ForeColor = System.Drawing.Color.White;
            this.addVehiclebtn.Location = new System.Drawing.Point(305, 280);
            this.addVehiclebtn.Name = "addVehiclebtn";
            this.addVehiclebtn.Size = new System.Drawing.Size(110, 40);
            this.addVehiclebtn.TabIndex = 12;
            this.addVehiclebtn.Text = "Add Vehicle";
            this.addVehiclebtn.UseVisualStyleBackColor = false;
            this.addVehiclebtn.Click += new System.EventHandler(this.addVehiclebtn_Click);
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.addVehiclebtn);
            this.Controls.Add(this.vehicleClassCB);
            this.Controls.Add(this.vehicleClass);
            this.Controls.Add(this.vehicleTypeCB);
            this.Controls.Add(this.vehicleNumberTB);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.vehicleNumber);
            this.Controls.Add(this.vehicleModel);
            this.Controls.Add(this.brandnameCB);
            this.Controls.Add(this.home);
            this.Controls.Add(this.vehicleModelTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addVehicle";
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.addVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleModelTB;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.ComboBox brandnameCB;
        private System.Windows.Forms.Label vehicleModel;
        private System.Windows.Forms.Label vehicleNumber;
        private System.Windows.Forms.Label vehicleType;
        private System.Windows.Forms.TextBox vehicleNumberTB;
        private System.Windows.Forms.ComboBox vehicleTypeCB;
        private System.Windows.Forms.Label vehicleClass;
        private System.Windows.Forms.ComboBox vehicleClassCB;
        private System.Windows.Forms.Button addVehiclebtn;
    }
}

