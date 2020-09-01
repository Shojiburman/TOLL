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
    public partial class vehicleList : Form
    {
        private Thread th;

        public vehicleList()
        {
            try
            {
                InitializeComponent();
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                SqlCommand command = new SqlCommand("select [Vehicle Number], [Vehicle Type] from vehicle where Username ='" + Program.userName + "'", con);   //Generating SQL Query
                con.Open();  //Opening the connection:

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    ndftb.Visible = true;
                    ndftb.Text= "No Data Found";
                    //vehicleListdgv.Rows[0].Cells[1].Value = "No Data Found";
                    //MessageBox.Show("No Data Found");
                    //this.Close();
                    //th = new Thread(openNewForm2);
                    //th.SetApartmentState(ApartmentState.STA);
                    //th.Start();
                }
                else 
                {
                    SqlDataReader DR = command.ExecuteReader();  //Execute SQL Query:
                    BindingSource source = new BindingSource();   //Binding reader to binding source
                    source.DataSource = DR;
                    vehicleListdgv.DataSource = source;  //Binding gridview or control datacsource to binding source:
                    con.Close();

                    //Generating SQL Query
                    String salutation = Program.userName;
                    //MessageBox.Show(salutation);
                    SqlCommand command2 = new SqlCommand("select [Vehicle Number] from vehicle where Username = '" + salutation + "';", con);
                    con.Open();  //Opening the connection:

                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    DataSet ds2 = new DataSet();

                    adapter2.SelectCommand = command2;
                    adapter2.Fill(ds2);

                    foreach (DataTable table in ds2.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            vehicListcb.Items.Add(dr["Vehicle Number"].ToString());
                        }
                    }
                }
                con.Close();  //Disconnect
            } catch(Exception ex)
            {
                MessageBox.Show("DB error");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (vehicListcb.Text.Length != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    //ConnectionString:
                    con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                    //Generating SQL Query
                    SqlCommand command = new SqlCommand("DELETE FROM vehicle WHERE  [Vehicle Number] = '" + vehicListcb.Text + "';", con);

                    //Opening the connection:
                    con.Open();

                    //Execute SQL Query:
                    SqlDataReader DR = command.ExecuteReader();
                    MessageBox.Show("Deleted Successfully!");
                    con.Close();

                    this.Close();
                    th = new Thread(openNewForm3);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                catch (SystemException ex)
                {
                    MessageBox.Show("DB Error");
                }
            }
            else 
            {
                MessageBox.Show("Select a vehicle");
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            ndftb.Visible = false;
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

        private void openNewForm3(object obj)
        {
            vehicleList f2 = new vehicleList();
            Application.Run(f2);
        }
    }
}
