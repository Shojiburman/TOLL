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
    public partial class addToll : Form
    {
        private Thread th;

        public addToll()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm(object obj)
        {
            adminPanel f2 = new adminPanel();
            Application.Run(f2);
        }

        private void addTollbtn_Click(object sender, EventArgs e)
        {
            if (placeTB.Text.Length == 0 || priceTB.Text.Length == 0)
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
                    //Toll unique
                    con.Open();
                    bool exists = false;
                    // create a command to check if the Toll name exists
                    using (SqlCommand cmd1 = new SqlCommand("select count(*) from toll_info where Place = @place", con))
                    {
                        cmd1.Parameters.AddWithValue("place", placeTB.Text);
                        exists = (int)cmd1.ExecuteScalar() > 0;
                        // if exists, show a message error
                        if (exists)
                        {
                            MessageBox.Show("This place is exist");
                        }
                        else
                        {
                            String salutaion = Program.userName;
                            //inserting data
                            String sql = "INSERT INTO toll_info(Place, Price, author) VALUES(@param1,@param2,@param3)";
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = placeTB.Text;
                                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = Convert.ToInt32(priceTB.Text);
                                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = salutaion;

                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Toll added successfully");
                                placeTB.Text = string.Empty;
                                priceTB.Text = string.Empty;
                                //Disconnect
                                con.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error");
                }
            }
        }
    }
}
