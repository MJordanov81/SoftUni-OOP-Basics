using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cat_Lady
{
    public class Cymric : Cat
    {
        private double furLEngth;

        public double FurLength
        {
            get { return furLEngth; }
            set { furLEngth = value; }
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurLength:f2}";
        }

    }
}
