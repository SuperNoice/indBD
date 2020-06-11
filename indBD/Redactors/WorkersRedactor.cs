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
    public partial class WorkersRedactor : Form
    {
        public enum startMode
        {
            Add, Edit, Delete
        }

        public WorkersRedactor(MainMenu mainMenu, startMode mode)
        {
            InitializeComponent();

            if (mode == startMode.Add)
            {

            }

            if (mode == startMode.Edit)
            {

            }

            if (mode == startMode.Delete)
            {

            }
        }

        private void workerCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
