using OperationsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XUnitDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reloadDropdown()
        {
            List<string> allNames = DatabaseClass.retrieveAllNames();
            allNamesList.DataSource = allNames;
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            int i =DatabaseClass.saveName(txtFirstName.Text, txtLastName.Text);
            if (i != 0)
            {
                MessageBox.Show("Data saved");
            }
            else
                MessageBox.Show("Data not saved");
            txtFirstName.Text = "";
            txtLastName.Text = "";

            reloadDropdown();

        }
    }
}
