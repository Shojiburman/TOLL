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
    public partial class userList : Form
    {
        private Thread th;

        public userList()
        {
            InitializeComponent();
            try
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();
                //ConnectionString:
                con.ConnectionString = "Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";

                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from users", con);
                //Opening the connection:
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                SqlDataReader DR = command.ExecuteReader();  //Execute SQL Query:
                BindingSource source = new BindingSource();   //Binding reader to binding source
                source.DataSource = DR;
                userListdgv.DataSource = source;  //Binding gridview or control datacsource to binding source:
                con.Close();  //Disconnect
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
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
    }
}
