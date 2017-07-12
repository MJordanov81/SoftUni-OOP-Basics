using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Drawing_tool
{
    public class StartUp
    {
        public static void Main()
        {
            var figureType = Console.ReadLine();

            switch (figureType)
            {
                case "Square":
                    var square = new Square(int.Parse(Console.ReadLine()));
                    CorDraw.DrawFigure(square);
                    break;
                case "Rectangle":
                    var rectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    CorDraw.DrawFigure(rectangle);
                    break;
            }
        }
    }
}
