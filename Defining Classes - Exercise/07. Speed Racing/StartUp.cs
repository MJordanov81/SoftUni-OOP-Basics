using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    class StartUp
    {
        private static List<Car> cars = new List<Car>();

        static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();
                cars.Add(new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));
            }

            var command = Console.ReadLine();

            while (command != "End" && command != String.Empty)
            {
                var tokens = command.Split();
                var model = tokens[1];
                var kilometers = int.Parse(tokens[2]);
                var currentCar = cars[cars.FindIndex(car => car.Model == model)];


                if (currentCar.IsThereEnoughFuel(kilometers))
                {
                    currentCar.DriveCar(int.Parse(tokens[2]));
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }

            cars.ForEach(car =>
            {
                Console.WriteLine(car.ToString());
            });
        }
    }
}
