using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public abstract class Food
    {
        private int happiness;

        public virtual int Happiness
        {
            get { return happiness; }
            set { happiness = value; }
        }
    }
}
