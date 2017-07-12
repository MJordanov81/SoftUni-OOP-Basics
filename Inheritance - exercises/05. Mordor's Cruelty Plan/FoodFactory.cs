using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public static class FoodFactory
    {
        public static Food GetFood(string foodName)
        {
            foodName = foodName.ToLower();

            switch (foodName)
            {
                case "cram": return new Cram();
                    break;
                case "lembas":
                    return new Lembas();
                    break;
                case "apple":
                    return new Apple();
                    break;
                case "melon":
                    return new Melon();
                    break;
                case "honeycake":
                    return new HoneyCake();
                    break;
                case "mushrooms":
                    return new Mushrooms();
                    break;
                default:
                    return new AnythigElse();
                    break;
            }
        }
    }
}
