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
        private List<Product> productList;
        private List<Customer> customerList;
        //private Dictionary<Customer, List<Product>> activeOrders;

        public Store()//
        {
            shopName = String.Empty;
            shopInfo = String.Empty;
            productList = new List<Product>();
            //activeOrders = new Dictionary<Customer, List<Product>>();
        }

        public Store(String shop)///
        {
            //read
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
        //public List<Product> ProductList { get; }

        public void AddProduct(Product p)
        {
            productList.Add(p);
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
