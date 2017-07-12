using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Topping
    {
        private static Dictionary<string, double> toppingType = new Dictionary<string, double>() { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };
        private const double CaloriesPerGram = 2.0;

        private double weight;
        private string type;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get { return type; }
            private set
            {
                if (toppingType.ContainsKey(value.ToLower()))
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value >= 1 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
            }
        }

        public double CalculateToppingCalories()
        {
            return this.Weight * CaloriesPerGram * toppingType[this.type.ToLower()];
        }
    }
}
