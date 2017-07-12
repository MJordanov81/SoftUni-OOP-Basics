using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shopping_Spree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> productList;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.ProductList = new List<Product>();
        }

        public List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        public double Money
        {
            get { return money; }
            private set {
                    if (value >= 0)
                    {
                        money = value;
                    }
                    else
                    {
                        throw new ArgumentException("Money cannot be negative");
                    }
                }
        }
   
        public string Name
        {
            get { return name; }
            private set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }

        public void BuyProduct(Product product, out bool canBuyProduct)
        {
            canBuyProduct = false;

            if (product.Cost <= this.Money)
            {
                this.Money -= product.Cost;
                this.ProductList.Add(product);

                canBuyProduct = true;
            }
        }

        public override string ToString()
        {
            if (this.ProductList.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", this.ProductList.Select(product => product.Name).ToList())}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }

        }
    }
}
