using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var list = new List<Shape>();

        list.Add(new Circle(3));
        list.Add(new Rectangle(4, 8));

        foreach (var element in list)
        {
            Console.WriteLine($"Perimeter: {element.CalculatePerimeter():f2}");
            Console.WriteLine($"Area: {element.CalculateArea():f2}");
            Console.WriteLine($"{element.Draw()}");
        }
    }
}

