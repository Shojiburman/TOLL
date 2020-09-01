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
    public partial class adminPanel : Form
    {
        private Thread th;
        String salutaion;

        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            salutaion = Program.userName;
            untextbox.Text = salutaion.ToUpper();
        }

        private void addToll_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm(object obj)
        {
            home f2 = new home();
            Application.Run(f2);
        }

        private void tollList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm4);
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
            addToll f2 = new addToll();
            Application.Run(f2);
        }

        private void manageToll_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void userList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void transactionList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm6(object obj)
        {
            manageToll f2 = new manageToll();
            Application.Run(f2);
        }

        private void openNewForm7(object obj)
        {
            userList f2 = new userList();
            Application.Run(f2);
        }

        private void openNewForm8(object obj)
        {
            transactionList f2 = new transactionList();
            Application.Run(f2);
        }
    }
}
