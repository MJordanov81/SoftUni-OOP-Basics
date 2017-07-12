using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box (double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }

        private double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }

        private double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }


        public double CalculateSurface()
        {
            return length * width * 2 + length * height * 2 + width * height * 2;
        }

        public double CalculateLateralSurface()
        {
            return length * height * 2 + width * height * 2;
        }

        public double CalculateVolume()
        {
            return length * width * height;
        }
    }
}
