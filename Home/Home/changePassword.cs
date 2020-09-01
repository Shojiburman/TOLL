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
    public partial class changePassword : Form
    {
        private Thread th;

        public changePassword()
        {
            InitializeComponent();
        }

        private void hone_Click(object sender, EventArgs e)
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

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                // validation: password being at least 6 characters
                if (currentPasswordTB.Text.Length < 6 || newPasswordTB.Text.Length < 6)
                {
                    MessageBox.Show("Please, enter a password with 6 or more characters");
                }
                else if (newPasswordTB.Text != confirmPasswordTB.Text)
                { // validation: password match
                    MessageBox.Show("New passwords don't match");
                }
                else if (currentPasswordTB.Text != Program.password)
                {
                    MessageBox.Show("Invalid Password");
                }
                else if (currentPasswordTB.Text == confirmPasswordTB.Text)
                {
                    MessageBox.Show("Password can't be the same as the current one, try a new password");
                }
                else 
                {
                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();
                    //ConnectionString:
                    con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
                    //Generating SQL Query
                    string sql = "UPDATE users SET PASSWORD = '" + confirmPasswordTB.Text + "' where USERNAME = '" + Program.userName + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Opening the connection:
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Successful");
                        Program.password = this.confirmPasswordTB.Text.ToString();
                        currentPasswordTB.Text = string.Empty;
                        newPasswordTB.Text = string.Empty;
                        confirmPasswordTB.Text = string.Empty;
                        //Disconnect
                        con.Close();
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }
    }
}
