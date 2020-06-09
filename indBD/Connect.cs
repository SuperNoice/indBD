using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace indBD
{
    public partial class Connect : Form
    {
        public bool doLogin = false;
        string login, pass, ip;

        public MySqlConnection connection = new MySqlConnection();

        public Connect()
        {
            InitializeComponent();

            if (System.IO.File.Exists("lastlogin.dat"))
            {
                string[] loginData = System.IO.File.ReadAllLines("lastlogin.dat");
                ipDbTextBox.Text = loginData[0];
                loginTextBox.Text = loginData[1];
                pass = EncodeDecrypt(loginData[2], 0x0088);
                passwordTextBox.Text = "*******";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isConnected;

            isConnected = true;

            ip = ipDbTextBox.Text.Trim();
            login = loginTextBox.Text.Trim();
            if (!System.IO.File.Exists("lastlogin.dat") || passwordTextBox.Text.Trim() != "*******")
                pass = passwordTextBox.Text.Trim();

            connection.ConnectionString = "password=" + pass + "; port=3306; server=" + ip + "; username=" + login;
            
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

            pass = EncodeDecrypt(pass, 0x0088);

            System.IO.File.WriteAllText("lastlogin.dat", ip + "\n" + login + "\n" + pass);

            doLogin = true;
            this.Close();
        }

        string EncodeDecrypt(string str, ushort secretKey)
        {
            string newStr = "";
            foreach (char c in str)
                newStr += TopSecret(c, secretKey);
            return newStr;
        }
        char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey);
            return character;
        }
    }
}
