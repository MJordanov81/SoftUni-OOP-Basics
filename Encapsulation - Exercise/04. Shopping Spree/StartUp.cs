using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shopping_Spree
{
    public class StartUp
    {
        private static List<Person> people = new List<Person>();
        private static List<Product> products = new List<Product>();

        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in input)
            {
                var currentTokens = person.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);

                var name = currentTokens[0];
                var money = double.Parse(currentTokens[1]);

                try
                {
                    people.Add(new Person(name, money));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

            }

            input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in input)
            {
                var currentTokens = product.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = currentTokens[0];
                var cost = double.Parse(currentTokens[1]);

                try
                {
                    products.Add(new Product(name, cost));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

            }

            var command = Console.ReadLine();

            while (!String.IsNullOrEmpty(command) && command != "END")
            {
                var tokens = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var personName = tokens[0];
                var productName = tokens[1];


                bool purchaseIsCompleted;

                people[people.FindIndex(person => person.Name == personName)].BuyProduct(products[products.FindIndex(product => product.Name == productName)], out purchaseIsCompleted);

                if (purchaseIsCompleted)
                {
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }

                command = Console.ReadLine();
            }

            people.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}
