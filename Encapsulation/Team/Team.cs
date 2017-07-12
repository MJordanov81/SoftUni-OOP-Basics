using System.Collections.Generic;
using System.Linq;

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.FirstTeam = new List<Person>();
            this.ReserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IList<Person> FirstTeam
        {
            get { return firstTeam.AsReadOnly(); }
            set { firstTeam = value.ToList(); }
        }

        public IList<Person> ReserveTeam
        {
            get { return reserveTeam.AsReadOnly(); }
            set { reserveTeam = value.ToList(); }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }

