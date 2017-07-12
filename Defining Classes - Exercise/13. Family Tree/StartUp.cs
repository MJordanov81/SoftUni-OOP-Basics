using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Family_Tree
{
    public class StartUp
    {
        private static List<Person> people = new List<Person>();
        private static List<string> relations = new List<string>();

        public static void Main()
        {
            var query = Console.ReadLine();

            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains('-'))
                {
                    relations.Add(input);
                }

                else
                {
                    var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var firstName = tokens[0];
                    var lastName = tokens[1];
                    var birthDate = tokens[2];

                    if (!CheckIfPersonExists(birthDate, false))
                    {
                        var currentPerson = new Person()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            BirthDate = birthDate,
                            Parents = new List<Person>(),
                            Children = new List<Person>()                            
                        };

                        people.Add(currentPerson);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var relation in relations)
            {
                var tokens = relation.Trim().Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries);

                var firstTokenIsAName = IsStringAName(tokens[0]);
                var secondTokenIsAName = IsStringAName(tokens[1]);

                var indexFirstPerson = GetIndexPerson(tokens[0], firstTokenIsAName);
                var indexSecondPerson = GetIndexPerson(tokens[1], secondTokenIsAName);

                people[indexFirstPerson].Children.Add(people[indexSecondPerson]);
                people[indexSecondPerson].Parents.Add(people[indexFirstPerson]);
            }

            var wantedPerson = people[GetIndexPerson(query, IsStringAName(query))];

            Console.WriteLine(wantedPerson.ToString());

        }

        private static int GetIndexPerson(string tokens, bool AreTokensAName)
        {
            if (AreTokensAName)
            {
                var firstName = tokens.Split()[0];
                var lastName = tokens.Split()[1];

                return people.FindIndex(person => person.FirstName == firstName && person.LastName == lastName);

            }
            else
            {
                return people.FindIndex(person => person.BirthDate == tokens);
            }
        }

        private static bool CheckIfPersonExists(string token, bool isTokenAName)
        {
            if (isTokenAName)
            {
                var firstName = token.Split()[0];
                var lastName = token.Split()[1];
                return people.Any(person => person.FirstName == firstName && person.LastName == lastName);
            }
            else
            {
                return people.Any(person => person.BirthDate == token);
            }
        }

        private static bool IsStringAName(string thisString)
        {
            return thisString.Split().Length == 2;
        }
    }
}
