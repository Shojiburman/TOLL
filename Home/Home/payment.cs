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
    public partial class payment : Form
    {
        private Thread th;

        public payment()
        {
            InitializeComponent();

            try
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select Place from toll_info", con);
                //Opening the connection:
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        placeNameCB.Items.Add(dr["Place"].ToString());
                    }
                }

                //Generating SQL Query
                String salutation = Program.userName;
                //MessageBox.Show(salutation);
                SqlCommand command2 = new SqlCommand("select [Vehicle Number] from vehicle where Username = '" + salutation + "';", con);

                adapter2.SelectCommand = command2;
                adapter2.Fill(ds2);

                foreach (DataTable table in ds2.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        vehicleNumberCB.Items.Add(dr["Vehicle Number"].ToString());
                    }
                }

                //Disconnect
                con.Close();

            } catch(Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            String price;
            if (placeNameCB.Text.Length == 0 || vehicleNumberCB.Text.Length == 0)
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
                    con.Open();

                    String place = placeNameCB.Text;
                    //MessageBox.Show(place);
                    //Generating SQL Query
                    SqlCommand command = new SqlCommand("select Price from toll_info where Place = '" + place + "'", con);
                    //Opening the connection:

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    price = Convert.ToString(ds.Tables[0].Rows[0]["Price"]);
                    //MessageBox.Show(price);

                    //inserting data
                    String sql = "INSERT INTO [Transaction](Place,Price,[Vehicle Number],Username) VALUES(@param1,@param2,@param3,@param4)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = placeNameCB.Text;
                        cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = price;
                        cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = vehicleNumberCB.Text;
                        cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = Program.userName;

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment Successful");
                        placeNameCB.Text = string.Empty;
                        vehicleNumberCB.Text = string.Empty;
                        //Disconnect
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error");
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm1(object obj)
        {
            profile f2 = new profile();
            Application.Run(f2);
        }

    }
}
