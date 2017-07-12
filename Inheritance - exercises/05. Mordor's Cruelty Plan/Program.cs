using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public class Program
    {
        public static void Main()
        {
            var foodList = new List<Food>();

            var input = Console.ReadLine().Split();

            foreach (var element in input)
            {
                foodList.Add(FoodFactory.GetFood(element));
            }

            var ttlPoints = foodList.Select(food => food.Happiness).Sum();

            var mood = MoodFactory.GetMood(ttlPoints);

            Console.WriteLine(mood);
        }
    }
}
