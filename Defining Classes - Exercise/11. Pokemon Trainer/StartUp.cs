using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Pokemon_Trainer
{
    public class StartUp
    {
        private static List<Trainer> trainers = new List<Trainer>();

        static void Main()
        {
            var input = Console.ReadLine();

            while (input != "Tournament" && input != String.Empty)
            {
                var tokens = input.Split();

                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                if (trainers.Count == 0 || !trainers.Any(t => t.Name == trainerName))
                {
                    var currentTrainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    trainers.Add(currentTrainer);
                }

                trainers[trainers.FindIndex(trainer => trainer.Name == trainerName)].Pokemons
                    .Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }

            var element = Console.ReadLine();

            while (element != "End" && element != String.Empty)
            {
                trainers.ForEach(trainer =>
                {
                    if (trainer.CheckIfHasElement(element))
                    {
                        trainer.IncreaseBadgesByOne();
                    }
                    else
                    {
                        trainer.DecreasePokemonsHealthByTen();
                        trainer.Pokemons = trainer.ReturnPokemonsWithNonNegativeOrZeroHealth();
                    }
                });

                element = Console.ReadLine();
            }

            trainers.OrderByDescending(trainer => trainer.Badges).ToList().ForEach(trainer =>
            {
                Console.WriteLine(trainer.ToString());
            });
        }
    }
}
