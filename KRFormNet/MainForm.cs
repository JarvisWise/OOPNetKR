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

        private void ShopTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {       
            FillShopTable(Controller.shop.GetAllProducts());////////\\\\\\\\\\\\\
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
                //ShopTable.Rows[ShopTable.RowCount - 1].Tag = product;
            }
        }


        private void FillBasket(List<Product> products)
        {
            Basket.Rows.Clear();
            foreach (Product product in products)
            {
                Basket.Rows.Add(new object[]
                {
                     product.Id, product.ProductName, product.Price, product.ProductNumber,
                     (product.Price*product.ProductNumber),
                     "Refuse",
                     "Buy"
                });
                //ShopTable.Rows[ShopTable.RowCount - 1].Tag = product;
            }
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
                Product value = (Product)ShopTable.CurrentRow.Tag;//check45
                //add to basket
                // change sql productNumber - ShopTable.CurrentRow.Cells[5].Value
            }


        }

        private void Basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //refuse
            {
                //delete form basket, add to products, update
            }

            if (e.ColumnIndex == 6) //buy
            {
                //delete form basket, update
            }
        }
    }
}
