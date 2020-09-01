using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static string _username = "";
        public static string userName
        {
            get { return _username; }
            set { _username = value; }
        }

        private static string _password = "";
        public static string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static SqlConnection getConn()
        {
            string connStr = @"Data Source=desktop-5ntub2n\\mssql2014;Initial Catalog=myDataBase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }
    }
}
