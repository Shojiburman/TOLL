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
    public partial class login : Form
    {
        private Thread th;

        private home hme;
        private profile pfle;

        public login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // validation: empty inputs
            int x = usernametb.Text.Length;
            int y = passwordtb.Text.Length;
            if (x == 0 && y == 0)
            {
                unerror.Visible = true;
                passerror.Visible = true;
            }
            if (x == 0)
            {
                unerror.Visible = true;
            }
            if (y == 0)
            {
                passerror.Visible = true;
            }
            if (x != 0 && y != 0)
            {
                unerror.Visible = false;
                passerror.Visible = false;
            }
            if (x != 0)
            {
                unerror.Visible = false;
            }
            if (y != 0)
            {
                passerror.Visible = false;
            }
            try
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from users where username='" + usernametb.Text + "'", con);

                //Opening the connection:
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds);
                String pass = Convert.ToString(ds.Tables[0].Rows[0]["PASSWORD"]);
                int admin = Convert.ToInt32(ds.Tables[0].Rows[0]["admin"]);
                //Disconnect
                con.Close();

                if (pass != passwordtb.Text)
                {
                    MessageBox.Show("Wrong credentials");
                }

                else
                {
                    //MessageBox.Show("Login Successful");
                    Program.userName = this.usernametb.Text.ToString();
                    Program.password = this.passwordtb.Text.ToString();
                    if (admin == 0)
                    {
                        this.Close();
                        th = new Thread(openNewForm4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else 
                    {
                        this.Close();
                        th = new Thread(openNewForm5);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm2(object obj)
        {
            home f2 = new home();
            Application.Run(f2);
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm3(object obj)
        {
            signup f2 = new signup();
            Application.Run(f2);
        }

        private void openNewForm4(object obj)
        {
            profile f2 = new profile();
            Application.Run(f2);
        }

        private void openNewForm5(object obj)
        {
            adminPanel f2 = new adminPanel();
            Application.Run(f2);
        }
    }
}
