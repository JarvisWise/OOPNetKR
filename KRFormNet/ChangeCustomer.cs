using KRFormNet.Source;
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
    public partial class ChangeCustomer : Form
    {
        private MainForm mainForm;
        private List<Source.Customer> customerList;
        /*public ChangeCustomer()
        {
            InitializeComponent();
        }*/
        public ChangeCustomer(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int i = ChangeComboBox.SelectedIndex;
            Controller.shop.ChangeCurrentCustomerId(Controller.currentCustomerId = customerList[i].Id);
            MessageBox.Show("Customer changed!");
            mainForm.UpdateAllTables();
            mainForm.SetInfo();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {
            customerList = Controller.shop.GetAllCustomer();
            string[] customers = new string[customerList.Count];
            for (int i = 0; i != customers.Length; i++)
                customers[i] = customerList[i].ToString();
            ChangeComboBox.Items.AddRange(customers);
            ChangeComboBox.SelectedIndex = 0;
        }
    }
}
