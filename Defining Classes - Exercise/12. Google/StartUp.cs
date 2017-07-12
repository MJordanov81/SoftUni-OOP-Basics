using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class StartUp
    {
        private static Dictionary<string, Person> people = new Dictionary<string, Person>();

        static void Main()
        {
            var input = Console.ReadLine().Trim();

            while (input != "End" && input != String.Empty)
            {
                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var personName = tokens[0];

                if (!people.ContainsKey(personName))
                {
                    var currentPerson = new Person(personName);
                    people[personName] = currentPerson;
                }

                var attribute = tokens[1];

                switch (attribute)
                {
                    case "company": var company = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));
                        people[personName].Company = company;
                        break;
                    case "pokemon": var pokemon = new Pokemon(tokens[2], tokens[3]);
                        people[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents": var parent = new Parent(tokens[2], tokens[3]);
                        people[personName].Parents.Add(parent);
                        break;
                    case "children": var child = new Child(tokens[2], tokens[3]);
                        people[personName].Children.Add(child);
                        break;
                    case "car": var car = new Car(tokens[2], int.Parse(tokens[3]));
                        people[personName].Car = car;
                        break;
                }

                input = Console.ReadLine();
            }

            var person = Console.ReadLine().Trim();


            if (people.ContainsKey(person))
            {
                Console.WriteLine(people[person].ToString());                
            }
        }
    }
}
