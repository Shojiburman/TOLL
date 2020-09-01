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
    public partial class manageToll : Form
    {
        private Thread th;

        public manageToll()
        {
            InitializeComponent();
            try
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                //Generating SQL Query
                SqlCommand command2 = new SqlCommand("select Place from toll_info", con);
                con.Open();  //Opening the connection:
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataSet ds2 = new DataSet();
                adapter2.SelectCommand = command2;
                adapter2.Fill(ds2);
                foreach (DataTable table in ds2.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        currentPlaceCB.Items.Add(dr["Place"].ToString());
                        deletePlaceCB.Items.Add(dr["Place"].ToString());
                    }
                }
                con.Close();  //Disconnect
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB error");
            }
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

        private void update_Click(object sender, EventArgs e)
        {
            if (newPlaceTB.Text.Length == 0 || currentPlaceCB.Text.Length == 0 || newPriceTB.Text.Length == 0)
            {
                MessageBox.Show("All the fields are required");
            }
            else
            {
                //try
                //{
                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();
                    //ConnectionString:
                    con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                    con.Open();
                    String salutaion = Program.userName;
                    //Updating data
                    string sql = "UPDATE toll_info SET Place = '" + newPlaceTB.Text + "', Price = '" + newPriceTB.Text + "', author = '" + Program.userName + "'  where Place = '" + currentPlaceCB.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Opening the connection:
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Successful");
                        newPlaceTB.Text = string.Empty;
                        currentPlaceCB.Text = string.Empty;
                        newPriceTB.Text = string.Empty;
                        //Disconnect
                        con.Close();
                    }
                //} catch (Exception ex)
                //{
                //    MessageBox.Show("DB Error");
                //}
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                //Generating SQL Query
                SqlCommand command = new SqlCommand("DELETE FROM toll_info WHERE Place = '" + deletePlaceCB.Text + "';", con);
                //Opening the connection:
                con.Open();
                //Execute SQL Query:
                SqlDataReader DR = command.ExecuteReader();
                MessageBox.Show("Deleted Successfully!");
                con.Close();

                this.Close();
                th = new Thread(openNewForm1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void openNewForm1(object obj)
        {
            manageToll f2 = new manageToll();
            Application.Run(f2);
        }
    }
}
