﻿using System;
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
        private String town = String.Empty;
        private DateTime DOB = new DateTime();
        private List<Product> productBasket = new List<Product>();

        public Customer()
        {
            firstName = String.Empty;
            secondName = String.Empty;
            thirdName = String.Empty;
            town = String.Empty;
            DOB = new DateTime();
            productBasket = new List<Product>();
        }


        public Customer(int id, String firstName, String secondName, String thirdName, String town, DateTime DOB, List<Product> productBasket)
        {
            if (id > 0) this.id = id;
            else id = 0;

            if (String.IsNullOrEmpty(firstName)) this.firstName = "";
            else this.firstName = firstName;

            if (String.IsNullOrEmpty(secondName)) this.secondName ="";
            else this.secondName = secondName;

            if (String.IsNullOrEmpty(thirdName)) this.thirdName = "";
            else this.thirdName = thirdName;

            if (String.IsNullOrEmpty(town)) this.town = "";
            else this.town = town;

            if (DOB != null) this.DOB = DOB;
            else this.DOB = new DateTime();

            if (productBasket != null) this.productBasket = productBasket;
            else this.productBasket = new List<Product>();

        }

        public int Id
        {
            get { return id; }
        }
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
        public String Town
        {
            get { return town; }
        }
        public List<Product> ProductBasket
        {
            get { return productBasket; }
        }

        public DateTime GetDOB
        {
            get { return DOB; }
        }

        public void AddToBasket(Product product)
        {
            Product p = productBasket.Find(x => x.Id == product.Id);
            if (p == null)
                productBasket.Add(product);
            else p.ProductNumber +=product.ProductNumber;
        }

        public void RemoveFromBasket(Product product)
        {
            Product p = productBasket.Find(x => x.Id == product.Id);
            if (p != null)
                productBasket.Remove(p);
        }

        

        public static Customer CustomerReader(IDataReader reader)
        {
            List<Product> basket = new List<Product>();
            if (reader["productBasket"] != null && Convert.ToString(reader["productBasket"])[0]!='-')
            {
                string[] list = Convert.ToString(reader["productBasket"]).Split(';');
                for (int i = 0; i != list.Length; i++)
                {
                    basket.Add(Product.ToProduct(list[i]));
                }
            }
            return new Customer(Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["firstName"]),
                Convert.ToString(reader["secondName"]),
                Convert.ToString(reader["thirdName"]),
                Convert.ToString(reader["town"]),
                Convert.ToDateTime(reader["DOB"]),
                basket
                );
        }

        public override string ToString()
        {
            return firstName + " " + secondName;
        }
    }
}
