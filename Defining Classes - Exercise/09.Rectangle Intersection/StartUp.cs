using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    public class StartUp
    {
        private static List<Rectangle> rectangles = new List<Rectangle>();

        static void Main()
        {
            var counts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            GetRectangles(counts[0]);

            CheckRectangles(counts[1]);
        }

        private static void CheckRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var idsOfRectanglesToCheck = Console.ReadLine().Split();

                var firstRectangle = GetRectangleById(idsOfRectanglesToCheck[0]);
                var secondRectangle = GetRectangleById(idsOfRectanglesToCheck[1]);

                Console.WriteLine(firstRectangle.IsThereIntersection(secondRectangle).ToString().ToLower());
            }
        }

        private static Rectangle GetRectangleById(string rectangleId)
        {
            return rectangles[rectangles.FindIndex(rectangle => rectangle.Id == rectangleId)];
        }

        private static void GetRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                var currentRectangle = new Rectangle(tokens[0],
                    double.Parse(tokens[1]),
                    double.Parse(tokens[2]),
                    new double[] { double.Parse(tokens[3]), double.Parse(tokens[4])});

                rectangles.Add(currentRectangle);
            }
        }
    }
}
