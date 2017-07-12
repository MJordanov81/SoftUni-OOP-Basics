using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cat_Lady
{
    public class StartUp
    {

        private static List<Cat> cats = new List<Cat>();

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "End" && input != String.Empty)
            {
                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Siamese": var siamese = new Siamese()
                        {
                            Name = tokens[1],
                            EarSize = int.Parse(tokens[2])
                        };
                        cats.Add(siamese);
                        break;
                    case "Cymric": var cymric = new Cymric()
                        {
                            Name = tokens[1],
                            FurLength = double.Parse(tokens[2]),
                        };
                        cats.Add(cymric);
                        break;
                    case "StreetExtraordinaire": var streetExtra = new StreetExtraordinaire()
                        {
                            Name = tokens[1],
                            DecibelsOfMeows = int.Parse(tokens[2])
                        };
                        cats.Add(streetExtra);
                        break;
                }

                input = Console.ReadLine();
            }

            var queryName = Console.ReadLine();

            Console.WriteLine(cats[cats.FindIndex(cat => cat.Name == queryName)].ToString());
        }
    }
}
