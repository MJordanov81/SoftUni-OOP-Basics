using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Football_Team_Generator
{
    public class Team
    {
        private string name;
        private double rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.Rating = 0d;
            this.Players = new List<Player>();
        }

        private List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public double Rating
        {
            get { return rating; }
            private set { rating = value; }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("A name should not be empty.");
                }
            }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.Players.Any(player => player.Name == playerName))
            {
                this.Players.RemoveAll(player => player.Name == playerName);
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }
        }

        public string GetRating()
        {
            if (this.Players.Count == 0)
            {
                return $"{this.Name} - 0";
            }

            var thisRating = (int)Math.Round(this.Players.Select(player => player.OverallSkill).Sum() /
                                          (double)this.Players.Count);
            return $"{this.Name} - {thisRating}";
        }
    }
}
