using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRFormNet
{
    public partial class Registration : Form
    {
        private MainForm mainForm;
        /*public Registration()
        {
            InitializeComponent();
        }*/

        public Registration(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FNTextBox.Text != "" && SNTextBox.Text != "" && TNTextBox.Text != "")
            {
                String fName = FNTextBox.Text;
                String sName = SNTextBox.Text;
                String tName = TNTextBox.Text;
                String town = TownComboBox.Text;
                DateTime DOB = DateTimePicker.Value;
                Controller.shop.AddCustomer(new Source.Customer(0, fName, sName, tName, town, DOB, new List<Source.Product>()));
                List<Source.Customer> customerList = Controller.shop.GetAllCustomer();
                Controller.shop.ChangeCurrentCustomerId(Controller.currentCustomerId =customerList.Count);
                MessageBox.Show("Customer Date saved!");
                mainForm.UpdateAllTables();
                mainForm.SetInfo();
                this.Close();
            }
            else {
                MessageBox.Show("Please fill in all fields!");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            TownComboBox.Items.AddRange(Controller.Towns);
            TownComboBox.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
