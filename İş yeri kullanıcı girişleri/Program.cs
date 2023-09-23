using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;


namespace İş_yeri_kullanıcı_girişleri
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
          static void Main(string[] args)
        {
            string server = "127.0.0.1";
            string database = "employeer_list";
            string username = "root";
            string password = "root";
            string constring = "SERVER=" + server + "" + "DATABASE=" + database + ";" +
                "UID=" + username + ";" + "PASSWORD=" + password + ";";
                MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from employeer_list";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
        }
    }
}
