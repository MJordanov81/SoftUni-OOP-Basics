using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Dough
    {
        private static Dictionary<string, double> flourTypes = new Dictionary<string, double>(){{"white", 1.5}, {"wholegrain", 1.0}};
        private static Dictionary<string, double> bakingTechniques = new Dictionary<string, double>(){ {"crispy", 0.9}, {"chewy", 1.1}, {"homemade", 1.0} };

        private const double CaloriesPerGram = 2.0;

        private double weight;
        private string flourType;
        private string bakingTechnique;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (bakingTechniques.ContainsKey(value.ToLower()))
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (flourTypes.ContainsKey(value.ToLower()))
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value >= 1 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

            }
        }

        public double CalculateDoughCalories()
        {
            return this.Weight * CaloriesPerGram * flourTypes[this.FlourType.ToLower()] * bakingTechniques[this.BakingTechnique.ToLower()];
        }
    }
}
