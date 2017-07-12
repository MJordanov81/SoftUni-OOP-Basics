using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shopping_Spree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public double Cost
        {
            get { return cost; }
            private set
            {
                if (value >= 0)
                {
                    cost = value;
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

    }
}
