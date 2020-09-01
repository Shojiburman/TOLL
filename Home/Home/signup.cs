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
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Threading;

namespace Home
{
    public partial class signup : Form
    {
        private Thread th;

        public signup()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            // validation: empty inputs
            if (usernametb.Text.Length == 0 || passwordtb.Text.Length == 0 || fullnametb.Text.Length == 0 || phonenumbertb.Text.Length == 0)
            {
                MessageBox.Show("All the fields except DOB are required");
            }
            else if (passwordtb.Text.Length < 6)   // validation: password should at least 6 characters
            {
                MessageBox.Show("Please, enter a password with 6 or more characters");
            }
            else if (new Regex(@"^(?:\+?88|0088)?01[15-9]\d{8}$").IsMatch(phonenumbertb.Text) != true) // regular expression to check BD numbers
            {
                MessageBox.Show("Invalid Bangladeshi Phone number");
            }
            else
            {
                try
                {
                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();
                    //ConnectionString:
                    con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                    //username unique
                    con.Open();
                    bool exists = false;
                    // create a command to check if the username exists
                    using (SqlCommand cmd1 = new SqlCommand("select count(*) from [users] where username = @UserName", con))
                    {
                        cmd1.Parameters.AddWithValue("UserName", usernametb.Text);
                        exists = (int)cmd1.ExecuteScalar() > 0;
                        // if exists, show a message error
                        if (exists)
                        {
                            MessageBox.Show("This username has been using by another user");
                        }
                        else
                        {
                            //inserting data
                            String sql = "INSERT INTO USERS(USERNAME,PASSWORD,FULLNAME,PHONE,DOB) VALUES(@param1,@param2,@param3,@param4,@param5)";
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = usernametb.Text;
                                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = passwordtb.Text;
                                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = fullnametb.Text;
                                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = phonenumbertb.Text;
                                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = dobdtp.Value.ToString("yyyy-MM-dd");

                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                //MessageBox.Show("Sign up Successful");

                                this.Close();
                                th = new Thread(openNewForm4);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();

                                usernametb.Text = string.Empty;
                                passwordtb.Text = string.Empty;
                                fullnametb.Text = string.Empty;
                                phonenumbertb.Text = string.Empty;
                                dobdtp.Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
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

        private void home_Click(object sender, EventArgs e)
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

        private void login_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm3(object obj)
        {
            login f2 = new login();
            Application.Run(f2);
        }

        private void openNewForm4(object obj)
        {
            login f2 = new login();
            Application.Run(f2);
        }
    }
}
