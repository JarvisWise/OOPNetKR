using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KRFormNet.Source
{
    class Product
    {
        private int id = 0;
        private String productName = String.Empty;
        private double price = 0;
        private int productNumber = 0;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String ProductName
        {
            get { return productName; }
        }

        public double Price
        {
            get { return price; }
        }

        public int ProductNumber 
        {
            get { return productNumber; }
            set { productNumber = value; }
        }

        public Product()//
        {
            id = 0;
            productName = String.Empty;
            price = 0;
            productNumber = 0;
        }

        public Product(int id, String productName, double price, int productNumber)
        {
            if (id < 0)
                throw new Exception();///formatException
            else
                this.id = id;

            if (String.IsNullOrEmpty(productName))
                throw new Exception();///formatException
            else
                this.productName = productName;

            if (price <= 0)
                throw new Exception();///formatException
            else
                this.price = price;

            if (price < 0)
                throw new Exception();///formatException
            else
                this.productNumber = productNumber;
        }

        public static Product ProductReader(IDataReader reader)
        {
            return new Product(Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["productName"]),
                Convert.ToDouble(reader["price"]),
                Convert.ToInt32(reader["productNumber"]));
        }

        /*public static Product ProductReader(IDataReader reader)
        {
            return new Product((int)reader["Id"],
                (string)reader["productName"],
                (double)reader["price"],
                (int)reader["productNumber"]);
        }*/

        public override string ToString()
        {
            return id + ":"+ productName + ":"+price+":"+ productNumber;
        }

        public static Product ToProduct(String s)
        {
            string[] line = s.Split(':');
            return new Product(Int32.Parse(line[0]), line[1], Double.Parse(line[2]), Int32.Parse(line[3]));
        }

        public override bool Equals(object obj)
        {
            Product p = (Product)obj;
            return id.Equals(p.id) && productName.Equals(p.productName) && price.Equals(p.price);
        }

    }
}
