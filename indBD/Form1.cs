using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace indBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("password=228369; port=3306; server=localhost; username=root; database=leonid");

            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand();

            DataTable table = new DataTable();


            



            connection.Close();
        }

       
    }
}
