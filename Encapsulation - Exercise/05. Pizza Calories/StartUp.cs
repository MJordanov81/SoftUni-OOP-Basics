using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class StartUp
    {
        private static Dough dough;
        private static List<Topping> toppings = new List<Topping>();

        public static void Main()
        {
            var input = Console.ReadLine();

            var tokens = input.Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "Pizza")
            {
                var pizzaName = tokens[1];
                var toppingsCount = int.Parse(tokens[2]);

                try
                {
                    var pizza = new Pizza(pizzaName, toppingsCount);

                    AddDough(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    pizza.DoughType = dough;

                    for (int i = 0; i < toppingsCount; i++)
                    {
                        AddTopping(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    }
                    pizza.Toppings = toppings.ToArray();

                    Console.WriteLine(pizza.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else
            {
                while (input != "END")
                {
                    tokens = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (tokens[0])
                    {
                        case "Dough":
                            try
                            {
                                AddDough(tokens);
                                Console.WriteLine($"{dough.CalculateDoughCalories():f2}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                            break;
                        case "Topping":
                            try
                            {
                                AddTopping(tokens);
                                Console.WriteLine($"{toppings[0].CalculateToppingCalories():f2}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                            break;
                    }

                    input = Console.ReadLine();
                }
            }
        }

        private static void AddTopping(string[] tokens)
        {
            toppings.Add(new Topping(tokens[1], double.Parse(tokens[2])));
        }

        private static void AddDough(string[] tokens)
        {
            dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
        }
    }
}
