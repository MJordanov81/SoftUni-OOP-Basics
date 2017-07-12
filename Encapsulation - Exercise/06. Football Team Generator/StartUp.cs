using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Football_Team_Generator
{
    public class StartUp
    {
        private static List<Team> teams = new List<Team>();

        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Trim().Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Team":
                        try
                        {
                            if (!teams.Any(team => team.Name == tokens[1]))
                            {
                                teams.Add(new Team(tokens[1]));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Add":
                        try
                        {
                            if (teams.Any(team => team.Name == tokens[1]))
                            {
                                teams[teams.FindIndex(team => team.Name == tokens[1])]
                                    .AddPlayer(new Player(tokens[2], 
                                                        int.Parse(tokens[3]), 
                                                        int.Parse(tokens[4]), 
                                                        int.Parse(tokens[5]), 
                                                        int.Parse(tokens[6]), 
                                                        int.Parse(tokens[7])));
                            }
                            else
                            {
                                Console.WriteLine($"Team {tokens[1]} does not exist.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Remove":
                        try
                        {
                            if (teams.Any(team => team.Name == tokens[1]))
                            {
                                teams[teams.FindIndex(team => team.Name == tokens[1])]
                                    .RemovePlayer(tokens[2]);
                            }
                            else
                            {
                                Console.WriteLine($"Team {tokens[1]} does not exist.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Rating":
                        try
                        {
                            if (teams.Any(team => team.Name == tokens[1]))
                            {
                                Console.WriteLine(teams[teams.FindIndex(team => team.Name == tokens[1])]
                                    .GetRating());
                            }
                            else
                            {
                                Console.WriteLine($"Team {tokens[1]} does not exist.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
