using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cat_Lady
{
    public class StreetExtraordinaire : Cat
    {
        private int decibelsOfMeows;

        public int DecibelsOfMeows
        {
            get { return decibelsOfMeows; }
            set { decibelsOfMeows = value; }
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.DecibelsOfMeows}";
        }
    }
}
