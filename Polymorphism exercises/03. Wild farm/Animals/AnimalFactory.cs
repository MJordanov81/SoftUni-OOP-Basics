using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm.Animals
{
    public static class AnimalFactory
    {
        public static Animal MakeAnimal(string animalType, string[] animalTokens)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat(animalTokens[0], 
                        animalTokens[1], 
                        double.Parse(animalTokens[2]), 
                        animalTokens[3], 
                        animalTokens[4]);

                case "Tiger":
                    return new Tiger(animalTokens[0],
                        animalTokens[1],
                        double.Parse(animalTokens[2]),
                        animalTokens[3]);

                case "Mouse":
                    return new Mouse(animalTokens[0],
                        animalTokens[1],
                        double.Parse(animalTokens[2]),
                        animalTokens[3]);

                default:
                    return new Zebra(animalTokens[0],
                        animalTokens[1],
                        double.Parse(animalTokens[2]),
                        animalTokens[3]);
            }
        }
    }
}
