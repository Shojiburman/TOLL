using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace Home
{
    public partial class addVehicle : Form
    {
        private Thread th;

        public addVehicle()
        {
            InitializeComponent();
        }

        private void addVehiclebtn_Click(object sender, EventArgs e)
        {
            if (vehicleNumberTB.Text.Length == 0 || vehicleTypeTB.Text.Length == 0)
            {
                MessageBox.Show("All the fields are required");
            }
            else 
            {
                try 
                { 
                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();
                    //ConnectionString:
                    con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                    //vehicle number unique
                    con.Open();
                    bool exists = false;
                    // create a command to check if the vehicle number exists
                    using (SqlCommand cmd1 = new SqlCommand("select count(*) from vehicle where [Vehicle Number] = @vehicleNumber", con))
                    {
                        cmd1.Parameters.AddWithValue("vehicleNumber", vehicleNumberTB.Text);
                        exists = (int)cmd1.ExecuteScalar() > 0;
                        // if exists, show a message error
                        if (exists)
                        {
                            MessageBox.Show("This vehicle Number has been using by another user");
                        }
                        else
                        {
                            String salutaion = Program.userName;
                            //inserting data
                            String sql = "INSERT INTO vehicle([Vehicle Number],[Vehicle Type], Username) VALUES(@param1,@param2,@param3)";
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = vehicleNumberTB.Text;
                                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = vehicleTypeTB.Text;
                                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = salutaion;

                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Vehicle added successfully");
                                vehicleNumberTB.Text = string.Empty;
                                vehicleTypeTB.Text = string.Empty;
                                //Disconnect
                                con.Close();
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("DB Error");
                }
                    
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm2(object obj)
        {
            profile f2 = new profile();
            Application.Run(f2);
        }
    }
}
