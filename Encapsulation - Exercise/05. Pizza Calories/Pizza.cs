using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Pizza
    {
        private const int MinToppings = 0;
        private const int MaxToppings = 10;
        private const int MaxLengthPizzaName = 15;

        private string name;
        private Dough doughType;
        private Topping[] toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;

            if (numberOfToppings >= MinToppings && numberOfToppings <= MaxToppings)
            {
                this.Toppings = new Topping[numberOfToppings];
            }
            else
            {
                throw  new ArgumentException("Number of toppings should be in range [0..10].");
            }

        }

        public Topping[] Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public Dough DoughType
        {
            get { return doughType; }
            set { doughType = value; }
        }

        public string Name
        {
            get { return name; }
            set {
                    if (value.Length <= MaxLengthPizzaName && !String.IsNullOrEmpty(value))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    }
                }
        }

        public double CalculatePizzaCalories()
        {
            return this.DoughType.CalculateDoughCalories() +
                   this.Toppings.Sum(topping => topping.CalculateToppingCalories());
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculatePizzaCalories():f2} Calories.";
        }
    }
}
