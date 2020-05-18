using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KRFormNet.Source
{
    class Customer
    {
        private int id = 0;
        private String firstName = String.Empty;
        private String secondName = String.Empty;
        private String thirdName = String.Empty;
        private DateTime DOB = new DateTime();//
        private List<Product> productBasket = new List<Product>();

        public String FirstName
        {
            get { return firstName; }
        }
        public String SecondName
        {
            get { return secondName; }
        }
        public String ThirdName
        {
            get { return thirdName; }
        }

        public void AddToBasket(Product product)
        {
            //Product p = productBasket.Find(product);
        }

        public Customer()//
        {
            firstName = String.Empty;
            secondName = String.Empty;
            thirdName = String.Empty;
            DOB = new DateTime();//
            productBasket = new List<Product>();
        }

      
        public Customer(int id, String firstName, String secondName, String thirdName, DateTime DOB, List<Product> productBasket) 
        {
            if (id > 0) this.id = id;
            else ;//
            
            if (String.IsNullOrEmpty(firstName)) throw new Exception();///formatException
            else this.firstName = firstName;

            if (String.IsNullOrEmpty(secondName)) throw new Exception();///formatException
            else this.secondName = secondName;

            if (String.IsNullOrEmpty(thirdName)) throw new Exception();///formatException
            else this.thirdName = thirdName;

            if (DOB != null) this.DOB = DOB;
            else this.DOB = new DateTime();

            if (productBasket != null) this.productBasket = productBasket;
            else this.productBasket = new List<Product>();

        }

        public static Customer CustomerReader(IDataReader reader)
        {
            string[] list = Convert.ToString(reader["productBasket"]).Split(';');
            List<Product> basket = new List<Product>();
            for (int i = 0; i != list.Length; i++)
            {
                basket.Add(Product.ToProduct(list[i]));
            }

            return new Customer(Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["firstName"]),
                Convert.ToString(reader["secondName"]),
                Convert.ToString(reader["thirdName"]),
                Convert.ToDateTime(reader["DOB"]),
                basket
                );
        }
    }
}
