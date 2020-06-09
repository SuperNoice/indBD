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
    public partial class Connect : Form
    {
        public bool doLogin = false;

        public MySqlConnection connection = new MySqlConnection();

        public Connect()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isConnected;
            string login, pass, ip;

            isConnected = true;

            ip = ipDbTextBox.Text.Trim();
            login = loginTextBox.Text.Trim();
            pass = passwordTextBox.Text.Trim();

            connection.ConnectionString = "password=" + pass + "; port=3306; server=" + ip + "; username=" + login + "; database=lombard";

            try { connection.Open(); }
            catch (Exception) { isConnected = false; }

            if (isConnected == false)
            {
                ipDbTextBox.BackColor = Color.FromArgb(255, 130, 130);
                loginTextBox.BackColor = Color.FromArgb(255, 130, 130);
                passwordTextBox.BackColor = Color.FromArgb(255, 130, 130);
                errorLabel.Visible = true;
                return;
            }

            doLogin = true;
            this.Close();
        }
    }
}
