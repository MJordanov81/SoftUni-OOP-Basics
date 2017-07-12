using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemons = pokemons;
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool CheckIfHasElement(string element)
        {
            return this.Pokemons.Any(pokemon => pokemon.Element == element);
        }

        public void IncreaseBadgesByOne()
        {
            this.Badges++;
        }

        public void DecreasePokemonsHealthByTen()
        {
            this.Pokemons.ToList().ForEach(pokemon => pokemon.Health -= 10);
        }

        public List<Pokemon> ReturnPokemonsWithNonNegativeOrZeroHealth()
        {
            return this.Pokemons.Where(pokemon => pokemon.Health > 0).ToList();
        }

        public override string ToString()
        {
            return string.Format($"{this.Name} {this.Badges} {this.Pokemons.Count}");
        }
    }
}
