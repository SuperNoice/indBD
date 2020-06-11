using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indBD
{
    public partial class CategoryRedactor : Form
    {
        MainWindow mainWindow;

        public enum startMode
        {
            Add, Edit, Delete
        }

        startMode mode;
        public CategoryRedactor(MainWindow mainWindow, startMode mode)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.mode = mode;

            categoryCodeComboBox.DataSource = mainWindow.getCurrentRowsList("SELECT `Код категории` FROM `Категории`", "Код категории", false);

            if (mode == startMode.Add)
            {
                confirmButton.Text = "Добавить";
                confirmButton.Click += add_button;
                categoryCodeComboBox.Visible = false;
                label2.Visible = false;

            }

            if (mode == startMode.Edit)
            {
                confirmButton.Text = "Изменить";
                confirmButton.Click += edit_button;
            }

            if (mode == startMode.Delete)
            {
                confirmButton.Text = "Удалить";
                confirmButton.Click += delete_button;
            }
        }

        private void categoryCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = mainWindow.DoSqlCommand("SELECT Категория FROM Категории WHERE `Код категории` = " + categoryCodeComboBox.SelectedItem.ToString());
            if (mode != startMode.Add)
            {
                categoryNameMaskedTextBox.Text = data.Rows[0].Field<string>("Категория");
            }
        }

        private void add_button(object sender, EventArgs e)
        {
            mainWindow.DoSqlCommand("INSERT INTO `Категории` VALUES(NULL,'" + categoryNameMaskedTextBox.Text.Trim() + "')");
            mainWindow.mainDataGridView.DataSource = mainWindow.DoSqlCommand("SELECT * FROM Категории");
            this.Close();
        }

        private void edit_button(object sender, EventArgs e)
        {
            mainWindow.DoSqlCommand("UPDATE `Категории` SET `Категория` = '" + categoryNameMaskedTextBox.Text.Trim() + "' WHERE `Код категории` = " + categoryCodeComboBox.SelectedItem.ToString());
            mainWindow.mainDataGridView.DataSource = mainWindow.DoSqlCommand("SELECT * FROM Категории");
            this.Close();
        }

        private void delete_button(object sender, EventArgs e)
        {
            mainWindow.DoSqlCommand("DELETE FROM `Категории` WHERE `Код категории` = " + categoryCodeComboBox.SelectedItem.ToString());
            mainWindow.mainDataGridView.DataSource = mainWindow.DoSqlCommand("SELECT * FROM Категории");
            this.Close();
        }

    }
}
