using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Car_Salesman
{
    public class StartUp
    {
        private static List<Engine> engines = new List<Engine>();
        private static List<Car> cars = new List<Car>();

        static void Main()
        {
            var enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                switch (tokens.Length)
                {
                    case 2: var currentEngine = new Engine(tokens[0], int.Parse(tokens[1]));
                        engines.Add(currentEngine);
                        break;
                    case 3:
                        currentEngine = new Engine(tokens[0], int.Parse(tokens[1]));
                        int displacement;
                        var isDisplacement = int.TryParse(tokens[2], out displacement);

                        if (isDisplacement)
                        {
                            currentEngine.Displacement = displacement;
                        }
                        else
                        {
                            currentEngine.Efficiency = tokens[2];
                        }
                        engines.Add(currentEngine);
                        break;
                    case 4: currentEngine = new Engine(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), tokens[3]);
                        engines.Add(currentEngine);
                        break;
                }
            }

            var carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                var tokens = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var engine = engines[engines.FindIndex(eng => eng.Model == tokens[1])];

                switch (tokens.Length)
                {
                    case 2: var currentCar = new Car(tokens[0], engine);
                        cars.Add(currentCar);
                        break;
                    case 3:
                        currentCar = new Car(tokens[0], engine);

                        int weight;
                        var isWeight = int.TryParse(tokens[2], out weight);

                        if (isWeight)
                        {
                            currentCar.Weight = weight;
                        }
                        else
                        {
                            currentCar.Color = tokens[2];
                        }

                        cars.Add(currentCar);
                        break;
                    case 4:
                        currentCar = new Car(tokens[0], engine, int.Parse(tokens[2]), tokens[3]);
                        cars.Add(currentCar);
                        break;
                }
            }

            cars.ForEach(car =>
            {
                Console.WriteLine(car.ToString());
            });
        }
    }
}
