using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Wild_farm.Animals;
using _03.Wild_farm.Foods;

namespace _03.Wild_farm
{
    public class Program
    {
        public static void Main()
        {
            var inputAnimal = Console.ReadLine();

            while (!String.IsNullOrEmpty(inputAnimal) && inputAnimal != "End")
            {
                var inputFood = Console.ReadLine();

                var animalTokens = inputAnimal.Split();
                var foodTokens = inputFood.Split();

                Animal animal = AnimalFactory.MakeAnimal(animalTokens[0], animalTokens);
                Food food = FoodFactory.MakeFood(foodTokens[0], foodTokens);

                animal.MakeSound();
                animal.Eat(food);
                Console.WriteLine(animal.ToString());

                inputAnimal = Console.ReadLine();
            }
        }
    }
}
