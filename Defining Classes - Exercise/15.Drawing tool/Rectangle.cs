using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Drawing_tool
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"|" + (new String('-', Width)) + $"|\n");

            for (int i = 0; i < Height - 2; i++)
            {
                result.Append($"|" + (new String(' ', Width)) + $"|\n");
            }

            result.Append($"|" + (new String('-', Width)) + $"|");

            return result.ToString();
        }
    }
}
