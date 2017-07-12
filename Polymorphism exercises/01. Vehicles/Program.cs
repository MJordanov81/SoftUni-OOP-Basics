using System;
using System.Collections.Generic;

namespace _01.Vehicles
{
    public class Program
    {
        public static void Main()
        {
            var list = new Dictionary<string, Vehicle>();

            var carTokens = Console.ReadLine().Split();
            var truckTokens = Console.ReadLine().Split();
            var busTokens = Console.ReadLine().Split();

            list.Add(carTokens[0], new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3])));
            list.Add(truckTokens[0], new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3])));
            list.Add(busTokens[0], new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3])));

            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var commandTokens = Console.ReadLine().Split();

                if (commandTokens[0] == "DriveEmpty")
                {
                    list[commandTokens[1]].IsEmpty = true;
                    list[commandTokens[1]].Drive(double.Parse(commandTokens[2]));
                    list[commandTokens[1]].IsEmpty = false;
                }
                else if (commandTokens[0] == "Drive")
                {
                    list[commandTokens[1]].Drive(double.Parse(commandTokens[2]));
                }
                else
                {
                    list[commandTokens[1]].Refuel(double.Parse(commandTokens[2]));
                }

            }

            foreach (var vehicle in list)
            {
                Console.WriteLine(vehicle.Value.PrintOut());
            }
        }
    }
}
