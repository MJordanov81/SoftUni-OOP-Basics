using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public Person(string name, Company company, List<Pokemon> pokemons, List<Parent> parents, List<Child> children, Car car)
        {
            this.Name = name;
            this.Company = company;
            this.Pokemons = pokemons;
            this.Parents = parents;
            this.Children = children;
            this.Car = car;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public List<Child> Children
        {
            get { return children; }
            set { children = value; }
        }

        public List<Parent> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public override string ToString()
        {

            StringBuilder pokemonsSb = new StringBuilder();
            this.Pokemons.ForEach(pokemon =>
            {
                pokemonsSb.Append($"{pokemon.Name} {pokemon.Type}\n");
            });

            StringBuilder parentsSb = new StringBuilder();
            this.Parents.ForEach(parent =>
            {
                parentsSb.Append($"{parent.Name} {parent.Birthday}\n");
            });

            StringBuilder childrenSb = new StringBuilder();
            this.Children.ForEach(child =>
            {
                childrenSb.Append($"{child.Name} {child.Birthday}\n");
            });

            var result = new StringBuilder();

            result.Append($"{this.Name}\n");
            result.Append($"Company:\n");
            if (this.Company != null)
            {
                result.Append($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}\n");
            }
            result.Append($"Car:\n");
            if (this.Car != null)
            {
                result.Append($"{this.Car.Model} {this.Car.Speed}\n");
            }
            result.Append($"Pokemon:\n");
            result.Append(pokemonsSb);
            result.Append($"Parents:\n");
            result.Append(parentsSb);
            result.Append($"Children:\n");
            result.Append(childrenSb);

            return result.ToString();
        }
    }
}
