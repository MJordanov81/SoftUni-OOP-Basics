using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    public class StartUp
    {
        private static List<Car> cars = new List<Car>();

        static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                var model = tokens[0];

                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);

                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];

                var tyrePressure1 = double.Parse(tokens[5]);
                var tyreAge1 = int.Parse(tokens[6]);
                var tyrePressure2 = double.Parse(tokens[7]);
                var tyreAge2 = int.Parse(tokens[8]);
                var tyrePressure3 = double.Parse(tokens[9]);
                var tyreAge3 = int.Parse(tokens[10]);
                var tyrePressure4 = double.Parse(tokens[11]);
                var tyreAge4 = int.Parse(tokens[12]);

                var currentCar = new Car(model, 
                    new Cargo(cargoType, cargoWeight), 
                    new Engine(engineSpeed, enginePower), 
                    new Tire[]
                    {
                        new Tire(tyreAge1, tyrePressure1),
                        new Tire(tyreAge2, tyrePressure2),
                        new Tire(tyreAge3, tyrePressure3),
                        new Tire(tyreAge4, tyrePressure4),
                    });

                cars.Add(currentCar);

            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile": cars.Where(car => car.Cargo.Type == "fragile")
                        .Where(car => car.Tires.Any(tire => tire.Pressure < 1))
                        .ToList()
                        .ForEach(
                        car =>
                        {
                            Console.WriteLine($"{car.Model}");
                        });
                    break;
                case "flamable": cars.Where(car => car.Cargo.Type == "flamable")
                        .Where(car => car.Engine.Power > 250)
                        .ToList()
                        .ForEach(
                        car =>
                        {
                            Console.WriteLine($"{car.Model}");
                        });
                    break;
            }
        }
    }
}
