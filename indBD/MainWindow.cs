using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace indBD
{
    public partial class MainWindow : Form
    {
        MySqlConnection connection;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        DataTable table = new DataTable();

        public MainWindow()
        {
            InitializeComponent();

            Connect connectForm = new Connect();
            Application.Run(connectForm);
            if (connectForm.doLogin == false) { this.Close(); this.Dispose(true); }
            connection = connectForm.connection;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            command.Connection = connection;
            command.CommandText = "SELECT * FROM `tabl`";
            adapter.SelectCommand = command;

            adapter.Fill(table);

            dataGridView1.DataSource = table;


        }

        void ConnectionOpen()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        void ConnectionClose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        
    }
}
