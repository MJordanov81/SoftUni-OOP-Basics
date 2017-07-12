using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cat_Lady
{
    public class Siamese : Cat
    {
        private int earSize;

        public int EarSize
        {
            get { return earSize; }
            set { earSize = value; }
        }

        public override string ToString()
        {
            return $"Siamese {this.Name} {this.EarSize}";
        }
    }
}
