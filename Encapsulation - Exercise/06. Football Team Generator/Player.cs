using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private int overallSkill;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.OverallSkill = (int)Math.Round((endurance + sprint + dribble + passing + shooting) / 5.0);
        }

        public int OverallSkill
        {
            get { return overallSkill; }
            private set { overallSkill = value; }
        }

        private int Shooting
        {
            get { return shooting; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    shooting = value;
                }
                else
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }              
            }
        }


        private int Passing
        {
            get { return passing; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    passing = value;
                }
                else
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }
            }
        }


        private int Dribble
        {
            get { return dribble; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    dribble = value;
                }
                else
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
            }
        }


        private int Sprint
        {
            get { return sprint; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    sprint = value;
                }
                else
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                }
            }
        }


        private int Endurance
        {
            get { return endurance; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    endurance = value;
                }
                else
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                }
            }
        }


        public string Name
        {
            get { return name; }
            private set {
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

    }
}
