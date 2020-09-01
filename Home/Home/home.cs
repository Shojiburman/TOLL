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
    public partial class home : Form
    {
        private Thread th;
        public String salutation;
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm2(object obj)
        {
            signup f2 = new signup();
            Application.Run(f2);
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Visible = false;

            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm3(object obj)
        {
            login f2 = new login();
            Application.Run(f2);
        }

        public void setUsername(String s)
        {
            //this.salutation = s; // maintaining pseudo session by storing username from login/signup
            this.salutation = s;
        }

        public String getUsername()
        {
            return this.salutation; // serving the username 
        }
    }
}
