using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public class JavaScript : Mood
    {
        public JavaScript(int points)
            : base(points)
        {

        }

        public override string ToString()
        {
            return $"{this.Points}\nJavaScript";
        }
    }
}
