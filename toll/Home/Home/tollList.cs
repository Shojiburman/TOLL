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
    public partial class tollList : Form
    {
        private Thread th;

        public tollList()
        {
            InitializeComponent();
            try 
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";

                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from users where username='" + Program.userName + "'", con);
                //Opening the connection:
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                int admin = Convert.ToInt32(ds.Tables[0].Rows[0]["admin"]);

                if (admin == 0)
                {
                    SqlCommand command1 = new SqlCommand("select place, price from toll_info", con);   //Generating SQL Query
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataSet ds1 = new DataSet();

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(ds1);

                    if (ds1.Tables[0].Rows.Count == 0)
                    {
                        ndftb.Text = "No Dta Found";
                        //MessageBox.Show("No Data Found");
                        //this.Close();
                        //th = new Thread(openNewForm2);
                        //th.SetApartmentState(ApartmentState.STA);
                        //th.Start();
                    }
                    else
                    {
                        SqlDataReader DR = command1.ExecuteReader();  //Execute SQL Query:
                        BindingSource source = new BindingSource();   //Binding reader to binding source
                        source.DataSource = DR;
                        tollListdgv.DataSource = source;  //Binding gridview or control datacsource to binding source:
                    }
                }
                else 
                {
                    SqlCommand command2 = new SqlCommand("select place, price, author from toll_info", con);   //Generating SQL Query

                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    DataSet ds2 = new DataSet();

                    adapter2.SelectCommand = command2;
                    adapter2.Fill(ds2);

                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        ndftb.Visible = true;
                        ndftb.Text = "No Dta Found";
                        //MessageBox.Show("No Data Found");
                        //this.Close();
                        //th = new Thread(openNewForm2);
                        //th.SetApartmentState(ApartmentState.STA);
                        //th.Start();
                    }
                    else
                    {
                        SqlDataReader DR = command2.ExecuteReader();  //Execute SQL Query:
                        BindingSource source = new BindingSource();   //Binding reader to binding source
                        source.DataSource = DR;
                        tollListdgv.DataSource = source;  //Binding gridview or control datacsource to binding source:
                        
                    }
                }
                con.Close();  //Disconnect
            }
            catch(Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            ndftb.Visible = false;
            try
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from users where username='" + Program.userName + "'", con);
                //Opening the connection:
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                int admin = Convert.ToInt32(ds.Tables[0].Rows[0]["admin"]);
                //Disconnect
                con.Close();
                if (admin == 0)
                {
                    this.Close();
                    th = new Thread(openNewForm1);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    this.Close();
                    th = new Thread(openNewForm2);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("DB Error");
            }
            
        }

        private void openNewForm1(object obj)
        {
            profile f2 = new profile();
            Application.Run(f2);
        }

        private void openNewForm2(object obj)
        {
            adminPanel f2 = new adminPanel();
            Application.Run(f2);
        }
    }
}
