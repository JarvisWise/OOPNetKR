using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRFormNet.Source;

namespace KRFormNet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAllTables();
        }

        private void UpdateAllTables()
        {

            FillShopTable(Controller.shop.GetAllProducts());


            FillBasket(Controller.shop.GetCurrentCustomer().ProductBasket);
        }

        private void FillShopTable(List<Product> products)
        {
            ShopTable.Rows.Clear();
            foreach (Product product in products)
            {
                ShopTable.Rows.Add(new object[]
                {
                     product.Id, product.ProductName, product.Price, product.ProductNumber,
                     "+",
                     new Int32(),
                     "-",
                     "Add to basket"

                });
            }
        }

        private void FillBasket(List<Product> products)
        {
            Basket.Rows.Clear();

            double costWithoutDiscount = 0;
            double costWithDiscount = 0;
            int totalProductNumber = 0;
            foreach (Product product in products)
            {
                Basket.Rows.Add(new object[]
                {
                     product.Id, product.ProductName, product.Price, product.ProductNumber,
                     (product.Price*product.ProductNumber),
                     "Refuse"
                });
                costWithoutDiscount += product.Price * product.ProductNumber;
                totalProductNumber += product.ProductNumber;
            }

            if (costWithoutDiscount != 0)
                costWithoutDiscount += 100;//доставка

            /*   if (DateTime.Now.DayOfYear == Controller.shop.GetCurrentCustomerDOB().DayOfYear ||
                DateTime.Now.DayOfYear == Controller.shop.GetCurrentCustomerDOB().DayOfYear+1 ||
                DateTime.Now.DayOfYear == Controller.shop.GetCurrentCustomerDOB().DayOfYear+)*/

            if (DateTime.Now.DayOfYear - Controller.shop.GetCurrentCustomerDOB().DayOfYear >= 0 &&
                DateTime.Now.DayOfYear - Controller.shop.GetCurrentCustomerDOB().DayOfYear <=3)
            {
                costWithDiscount = costWithoutDiscount * 0.9;
            }
            else {
                if (costWithoutDiscount < 1000)
                    costWithDiscount = costWithoutDiscount;
                else if (costWithoutDiscount < 9000)
                    costWithDiscount = costWithoutDiscount * 0.95;
                else costWithDiscount = costWithoutDiscount * 0.92;
            }

                TotalNumberLabel.Text = totalProductNumber.ToString();
            WithoutDiscount.Text = costWithoutDiscount.ToString();
            WithDiscount.Text = costWithDiscount.ToString();
        }

        private void ShopTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //+
            {
                int value = Convert.ToInt32(ShopTable.CurrentRow.Cells[3].Value);
                int valueC = Convert.ToInt32(ShopTable.CurrentRow.Cells[5].Value);
                if (valueC < value)
                    ShopTable.CurrentRow.Cells[5].Value = 1 + valueC;
            }

            if (e.ColumnIndex == 6) //-
            {
                int value = Convert.ToInt32(ShopTable.CurrentRow.Cells[5].Value);
                if (value > 0)
                    ShopTable.CurrentRow.Cells[5].Value = value - 1;
            }

            if (e.ColumnIndex == 7) //add
            {
                int value = Convert.ToInt32(ShopTable.CurrentRow.Cells[3].Value);
                int valueC = Convert.ToInt32(ShopTable.CurrentRow.Cells[5].Value);


                Product toBasket = new Product(
                    Convert.ToInt32(ShopTable.CurrentRow.Cells[0].Value),
                    Convert.ToString(ShopTable.CurrentRow.Cells[1].Value),
                    Convert.ToDouble(ShopTable.CurrentRow.Cells[2].Value),
                    valueC 
                    );

                Product toProducts = new Product(
                   Convert.ToInt32(ShopTable.CurrentRow.Cells[0].Value),
                   Convert.ToString(ShopTable.CurrentRow.Cells[1].Value),
                   Convert.ToDouble(ShopTable.CurrentRow.Cells[2].Value),
                   (value - valueC)
                   );

                Controller.shop.AddToCurrentCustomerBasket(toBasket);
                Controller.shop.UpdateProduct(toProducts);
                UpdateAllTables();
            }


        }

        private void Basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //refuse
            {
                //delete form basket, add to products

                Product refuse = new Product(
                    Convert.ToInt32(Basket.CurrentRow.Cells[0].Value),
                    Convert.ToString(Basket.CurrentRow.Cells[1].Value),
                    Convert.ToDouble(Basket.CurrentRow.Cells[2].Value),
                     Convert.ToInt32(Basket.CurrentRow.Cells[3].Value)
                    );

                Product formProducts = Controller.shop.FindProductById(refuse.Id);
                formProducts.ProductNumber += refuse.ProductNumber;

                Controller.shop.UpdateProduct(formProducts);
                Controller.shop.RemoveFromCurrentCustomerBasket(refuse);
                UpdateAllTables();
            }

            /*if (e.ColumnIndex == 6) //no need remove this
            {
                //delete form basket
                UpdateAllTables();
            }*/
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= Controller.shop.StartDay && DateTime.Now.Hour <= Controller.shop.EndDay)
            {

                Controller.shop.ClearCurrentBasket();
                UpdateAllTables();
                MessageBox.Show("Purchase operation completed successfully");
            }
            else {
                MessageBox.Show("Sorry our store is closed, try during business hours("+ Controller.shop.StartDay.ToString("0.00") + " - "+ Controller.shop.EndDay.ToString("0.00") + ")");
            }

        }
    }
}
