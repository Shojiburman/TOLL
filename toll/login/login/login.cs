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


namespace login
{
    public partial class login : Form
    {
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
                SqlCommand command = new SqlCommand("select * from users where username="
                    + "'" + usernametb.Text + "' and Password=" + "'" + passwordtb.Text + "'", con);

                //Opening the connection:
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds);

                //Disconnect
                con.Close();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Wrong credentials");
                }

                else
                {
                    MessageBox.Show("Login Successful");
                    usernametb.Text = string.Empty;
                    passwordtb.Text = string.Empty;
                    this.Hide();
                    //var signup = new signup();
                    //signup.Closed += (s, args) => this.Close();
                    //signup.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }
    }
}
