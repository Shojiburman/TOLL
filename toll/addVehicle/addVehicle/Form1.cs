using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addVehicle
{
    public partial class addVehicle : Form
    {
        public addVehicle()
        {
            InitializeComponent();
        }

        private void addVehicle_Load(object sender, EventArgs e)
        {
            this.brandnameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.vehicleClassCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.vehicleTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addVehiclebtn_Click(object sender, EventArgs e)
        {
            string a1, a2, a3, a4, a5;
            try
            {
                a1 = brandnameCB.SelectedItem.ToString().Trim();
                a2 = vehicleModelTB.Text.Trim();
                a3 = vehicleNumberTB.Text.Trim();
                a4 = vehicleClassCB.SelectedItem.ToString().Trim();
                a5 = vehicleTypeCB.SelectedItem.ToString().Trim();
                if (a1.Length != 0 || a2.Length != 0 || a3.Length != 0 || a4.Length != 0 || a5.Length != 0)
                {
                    MessageBox.Show("Vehicle added successfully");
                }
                else
                {
                    MessageBox.Show("All fields are required");
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
