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
            string sqlCommand = "SHOW DATABASES";
            dataGridView1.DataSource = DoSqlCommand(sqlCommand);
        }

        void ConnectionOpen()
        {
            if (connection.State == ConnectionState.Closed)
                try { connection.Open(); }
                catch (Exception)
                {
                    Connect connectForm = new Connect();
                    connectForm.Show();
                }
        }

        void ConnectionClose()
        {
            if (connection.State == ConnectionState.Open)
                try { connection.Close(); }
                catch (Exception)
                {
                    Connect connectForm = new Connect();
                    connectForm.Show();
                }
        }

        DataTable DoSqlCommand(string sqlCommand)
        {
            DataTable table = new DataTable();
            ConnectionOpen();

            command.Connection = connection;
            command.CommandText = sqlCommand;

            adapter.SelectCommand = command;

            try { adapter.Fill(table); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error!"); }

            ConnectionClose();

            return table;
        }

    }
}
