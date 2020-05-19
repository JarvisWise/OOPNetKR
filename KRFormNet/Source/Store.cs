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

        //add time of work
        private int startDay = 6;
        private int endDay = 23;
        //private DateTime startDay = new DateTime();//new DateTime(0000, 0, 0, 6, 0, 0);//
        //private DateTime endDay = new DateTime();//new DateTime(0000, 0, 0, 23, 00, 0);//
        //private DateTime startDay = new DateTime(0000, 0, 0, 6, 0, 0);//
        //private DateTime endDay = new DateTime(0000, 0, 0, 23, 00, 0);//

        //

        private List<Product> productList;
        private Customer currentCustomer;

        public Store()//
        {
            shopName = String.Empty;
            shopInfo = String.Empty;

            //startDay = new DateTime();//
            //endDay = new DateTime();//

            //startDay = new DateTime(0000, 0, 0, 6, 0, 0);//
            //endDay = new DateTime(0000, 0, 0, 23, 00, 0);//

        productList = new List<Product>();
            currentCustomer = new Customer();
        }

        public Store(String shop)///
        {
            //read
        }

        //add time of work
        //private DateTime startDay = new DateTime();//
        //private DateTime endDay = new DateTime();//
        //

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

        /*public void AddOrder(Customer user, Product product)
        {
            //add validate
            activeOrders[user].Add(product);
        }

        public void DeleteOrder(Customer user, Product product)
        {
            if (!activeOrders[user].Remove(product))
                throw new Exception(); // add format
        }*/
    }
}
