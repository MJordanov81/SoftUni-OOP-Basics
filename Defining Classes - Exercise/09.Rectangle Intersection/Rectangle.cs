using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double[] upperLeftCorner;

        public Rectangle(string id, double width, double height, double[] upperLeftCorner)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.UpperLeftCorner = upperLeftCorner;
        }

        public double[] UpperLeftCorner
        {
            get { return upperLeftCorner; }
            set { upperLeftCorner = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool IsThereIntersection(Rectangle rectangle)
        {
            if (this.upperLeftCorner[0] + this.Width < rectangle.UpperLeftCorner[0]
                || rectangle.UpperLeftCorner[0] + rectangle.Width < this.UpperLeftCorner[0]
                || this.UpperLeftCorner[1] + this.Height < rectangle.UpperLeftCorner[1]
                || rectangle.UpperLeftCorner[1] + rectangle.Height < this.UpperLeftCorner[1])
            {
                return false;
            }

            return true;
        }
    }
}
