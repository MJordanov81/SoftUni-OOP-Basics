using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm.Foods
{
    public static class FoodFactory
    {
        public static Food MakeFood(string foodType, string[] foodTokens)
        {
            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(int.Parse(foodTokens[1]));
                default: return new Meat(int.Parse(foodTokens[1]));
            }
        }
    }
}
