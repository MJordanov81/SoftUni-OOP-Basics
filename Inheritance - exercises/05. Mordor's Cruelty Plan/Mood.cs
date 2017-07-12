using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public abstract class Mood
    {
        private int points;

        public Mood(int points)
        {
            this.Points = points;
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
