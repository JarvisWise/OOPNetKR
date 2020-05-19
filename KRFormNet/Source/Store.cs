using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace KRFormNet.Source
{
    class Store
    {
        private String shopName;
        private String shopInfo;
        private int startDay;
        private int endDay;

        private List<Product> productList;
        private Customer currentCustomer;

        public Store()//
        {
            ReadStoreInfo();
            productList = new List<Product>();
            currentCustomer = new Customer();
        }

        public String ShopName
        {
            get { return shopName; }
        }

        public String ShopInfo
        {
            get { return shopInfo; }
        }

        public int StartDay
         {
            get { return startDay; }
         }

        public int EndDay
        {
            get { return endDay; }
        }


        public DateTime GetCurrentCustomerDOB()
        {
            return currentCustomer.GetDOB;
        }

        public String GetCurrentCustomerFName()
        {
            return currentCustomer.FirstName;
        }
        public String GetCurrentCustomerSName()
        {
            return currentCustomer.SecondName;
        }
        public String GetCurrentCustomerTName()
        {
            return currentCustomer.ThirdName;
        }

        public void ClearCurrentBasket()
        {
            currentCustomer.ProductBasket.Clear();
            UpdateCurrentCustomer();
        }

        public void AddToCurrentCustomerBasket(Product product)
        {
            currentCustomer.AddToBasket(product);
            UpdateCurrentCustomer();
        }

        public void RemoveFromCurrentCustomerBasket(Product product)
        {
            currentCustomer.RemoveFromBasket(product);
            UpdateCurrentCustomer();
        }

        public Product FindProductById(int id)
        {
            GetAllProducts();
            Product p = productList.Find(x => x.Id == id);
            if (p == null)
                return null;
            else return p;
        }

        public List<Product> GetAllProducts()
        {
            productList = new List<Product>();
            using (SqlConnection connection = new SqlConnection(Controller.connString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Products]", connection))
            {
                connection.Open();
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                        productList.Add(Product.ProductReader(sqlReader));
                }
            }
            return productList;
        }

        public Customer GetCurrentCustomer()
        {
            using (SqlConnection connection = new SqlConnection(Controller.connString))//
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Customers]", connection))//
            {
                connection.Open();
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    if (sqlReader.Read())
                        currentCustomer = Customer.CustomerReader(sqlReader);
                    else { }//
                }
            }
            return currentCustomer;
        }

        public void ReadStoreInfo()
        {
            using (SqlConnection connection = new SqlConnection(Controller.connString))//
            using (SqlCommand command = new SqlCommand("SELECT * FROM [StoreInfo]", connection))//
            {
                connection.Open();
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    if (sqlReader.Read())
                    {
                        shopName = Convert.ToString(sqlReader["shopName"]);
                        shopInfo = Convert.ToString(sqlReader["shopInfo"]);
                        startDay = Convert.ToInt32(sqlReader["startDay"]);
                        endDay = Convert.ToInt32(sqlReader["endDay"]);
                    }
                    else { }//
                }
            }
        }



        public void UpdateCurrentCustomer()
        {
            using (SqlConnection connection = new SqlConnection(Controller.connString))//
            using (SqlCommand command = new SqlCommand("UPDATE [Customers] SET [productBasket]=@productBasket WHERE [Id]=@id", connection))//
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", currentCustomer.Id);
                command.Parameters.AddWithValue("@productBasket", Product.ProductListToString(currentCustomer.ProductBasket));
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(Controller.connString))//
            using (SqlCommand command = new SqlCommand("UPDATE [Products] SET [productNumber]=@productNumber WHERE [Id]=@id", connection))//
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@productNumber", product.ProductNumber);
                command.ExecuteNonQuery();
            }
        }
    }
}
