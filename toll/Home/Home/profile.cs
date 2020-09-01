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
    public partial class profile : Form
    {
        private Thread th;
        String salutaion;

        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            salutaion = Program.userName;
            untextbox.Text = salutaion.ToUpper();
        }

        private void addVehiclebtn_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void vehicleListbtn_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm(object obj)
        {
            home f2 = new home();
            Application.Run(f2);
        }

        private void openNewForm2(object obj)
        {
            addVehicle f2 = new addVehicle();
            Application.Run(f2);
        }

        private void openNewForm3(object obj)
        {
            vehicleList f2 = new vehicleList();
            Application.Run(f2);
        }

        private void tollListbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void payTollbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void transactionListbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void changePassworsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm4(object obj)
        {
            tollList f2 = new tollList();
            Application.Run(f2);
        }

        private void openNewForm5(object obj)
        {
            payment f2 = new payment();
            Application.Run(f2);
        }

        private void openNewForm6(object obj)
        {
            transactionList f2 = new transactionList();
            Application.Run(f2);
        }

        private void openNewForm7(object obj)
        {
            changePassword f2 = new changePassword();
            Application.Run(f2);
        }

        
    }
}
