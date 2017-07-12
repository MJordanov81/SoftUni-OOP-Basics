using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
