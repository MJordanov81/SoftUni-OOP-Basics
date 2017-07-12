using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Program
    {
        public static void Main()
        {           
            while (true)
            {
                var animal = Console.ReadLine();

                if (animal == "Beast!")
                {
                    break;
                }

                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];
                int age;
                var isParsable = int.TryParse(tokens[1], out age);

                if (!isParsable)
                {
                    Console.WriteLine("Invalid input!");
                }               

                try
                {
                    if (animal != "Tomcat" && animal != "Kitten")
                    {
                        var gender = tokens[2];
                        Animal currentAnimal = AnimalFactory.GetAnimal(animal, name, age, gender);
                        Console.WriteLine(currentAnimal.ToString());
                    }
                    else
                    {
                        Animal currentAnimal = AnimalFactory.GetAnimal(animal, name, age);
                        Console.WriteLine(currentAnimal.ToString());
                    }                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
