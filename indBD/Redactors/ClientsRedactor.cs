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
    public partial class ClientsRedactor : Form
    {
        public enum startMode
        {
            Add, Edit, Delete
        }

        public ClientsRedactor(MainMenu mainMenu, startMode mode)
        {
            InitializeComponent();

            if (mode == startMode.Add)
            {
                codeClientComboBox.Visible = false;
                confirmButton.Text = "Добавить";
            }

            if (mode == startMode.Edit)
            {
                confirmButton.Text = "Изменить";
            }

            if (mode == startMode.Delete)
            {
                confirmButton.Text = "Удалить";

            }
        }

        private void codeClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_button(object sender, EventArgs e)
        {

        }

        private void edit_button(object sender, EventArgs e)
        {

        }

        private void delete_button(object sender, EventArgs e)
        {

        }
    }
}
