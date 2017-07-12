using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Drawing_tool
{
    public class Square : Rectangle
    {
        public Square (int side)
            : base(side, side)
        {
            this.Height = side;
            this.Width = side;
        }
    }
}
