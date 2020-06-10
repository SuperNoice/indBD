using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace indBD
{
    public partial class MainWindow : Form
    {
        int selectedRequest;
        MySqlConnection connection;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();

        public MainWindow()
        {
            InitializeComponent();

            Connect connectForm = new Connect();
            Application.Run(connectForm);
            if (connectForm.doLogin == false) { this.Close(); this.Dispose(true); return; }
            connection = connectForm.connection;

            //Инициализация
            DoSqlCommand(
                "CREATE DATABASE IF NOT EXISTS ломбард; " +
                "USE ломбард; " +

                "CREATE TABLE IF NOT EXISTS сотрудники (" +
                "`Код сотрудника` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "ФИО VARCHAR(40), " +
                "Должность VARCHAR(20)" +
                ")ENGINE = InnoDB; " +

                "CREATE TABLE IF NOT EXISTS Категории (" +
                "`Код категории` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "Категория VARCHAR(40)" +
                ")ENGINE = InnoDB; " +

                "CREATE TABLE IF NOT EXISTS Клиенты (" +
                "`Код клиента` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "ФИО VARCHAR(40), " +
                "`Дата рождения` DATE, " +
                "`Место жительства` VARCHAR(50), " +
                "Документ VARCHAR(40), " +
                "`Серия номер паспорта` VARCHAR(15), " +
                "`Дата выдачи` DATE, " +
                "`Кем выдан` VARCHAR(50), " +
                "`Контактный телефон` VARCHAR(15)" +
                ")ENGINE = InnoDB; " +

                "CREATE TABLE IF NOT EXISTS Договор (" +
                "`Код договора` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "Клиент INT, " +
                "`Дата выдачи` DATE, " +
                "`Минимальный срок залога` INT, " +
                "`Максимальный срок залога` INT, " +
                "`Размер ссуды` INT, " +
                "`Процент в день` INT, " +
                "`Процент в день за хранение` INT, " +
                "`Гарантированный срок хранения` INT, " +
                "`Фактическая дата выкупа` DATE, " +
                "`Фактическая сумма выкупа` DATE, " +
                "FOREIGN KEY(Клиент) REFERENCES Клиенты(`Код клиента`)" +
                ")ENGINE = InnoDB; " +

                "CREATE TABLE IF NOT EXISTS `Предметы залога` (" +
                "`Учетный код` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "`Код категории` INT, " +
                "Название VARCHAR(30), " +
                "Количество INT, " +
                "`Ед изм` VARCHAR(20), " +
                "Примечание VARCHAR(50), " +
                "`Оценочная стоимость` INT, " +
                "`Код товара` INT, " +
                "Статус VARCHAR(10), " +
                "FOREIGN KEY(`Код категории`) REFERENCES Категории(`Код категории`), " +
                "FOREIGN KEY(`Код товара`) REFERENCES Договор(`Код договора`)" +
                ")ENGINE = InnoDB; " +

                "CREATE TABLE IF NOT EXISTS Продажи (" +
                "`Код продажи` INT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "`Учетный код` INT, " +
                "`Цена продажи` INT, " +
                "Сотрудник INT, " +
                "`Дата продажи` DATE, " +
                "FOREIGN KEY(`Учетный код`) REFERENCES `Предметы залога`(`Учетный код`), " +
                "FOREIGN KEY(Сотрудник) REFERENCES Сотрудники(`Код сотрудника`)" +
                ")ENGINE = InnoDB; " +

                "");

            // Стартовая таблица
            setDefaultButtonColor();
            dogovorButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 1;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Договор");
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

        public DataTable DoSqlCommand(string sqlCommand)
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

        private void dogovorButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            dogovorButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 1;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Договор");
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            itemsButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 2;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM `Предметы залога`");
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            salesButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 3;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Продажи");
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            categoryButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 4;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Категории");
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            clientsButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 5;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Клиенты");
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            setDefaultButtonColor();
            workersButton.BackColor = Color.FromArgb(165, 208, 255);
            selectedRequest = 6;

            mainDataGridView.DataSource = DoSqlCommand("SELECT * FROM Сотрудники");
        }

        private void setDefaultButtonColor(Button button)
        {
            button.BackColor = SystemColors.ControlLight;
        }
        /// <summary>
        /// Устанавливает стандартный цвет всем кнопкам меню
        /// </summary>
        private void setDefaultButtonColor()
        {
            Color color = SystemColors.ControlLight;

            dogovorButton.BackColor = color;
            itemsButton.BackColor = color;
            salesButton.BackColor = color;
            categoryButton.BackColor = color;
            clientsButton.BackColor = color;
            workersButton.BackColor = color;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedRequest <= 6)
            {
                DoSqlCommand("INSERT INTO " + getTableName(selectedRequest) + " VALUES " + getValuesForInsert(selectedRequest));
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (selectedRequest <= 6)
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRequest <= 6)
            {

            }
        }

        private void reqestButton_Click(object sender, EventArgs e)
        {

        }

        private string getTableName(int selected)
        {
            switch (selected)
            {
                case 1: return "Договор";
                case 2: return "`Предметы залога`";
                case 3: return "Продажи";
                case 4: return "Категории";
                case 5: return "Клиенты";
                case 6: return "Сотрудники";

                default: return "none";
            }
        }

        private string getValuesForInsert(int selected)
        {
            switch (selected)
            {
                case 1: return "Договор";
                case 2: return "`Предметы залога`";
                case 3: return "Продажи";
                case 4: return "Категории";
                case 5: return "Клиенты";
                case 6: return "(NULL,'grhghrhsjhsjtjrtjsrjsrjtshehe',NULL)";

                default: return "none";
            }
        }
    }
}
