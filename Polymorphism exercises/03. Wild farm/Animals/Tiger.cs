using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Wild_farm.Foods;

namespace _03.Wild_farm.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
        }
    }
}
