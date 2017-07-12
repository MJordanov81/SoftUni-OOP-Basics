using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public static class AnimalFactory
    {
        public static Animal GetAnimal(string animal, string name, int age)
        {
            switch (animal)
            {
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    return new Animal(" ", 0, " ");
            }
        }

        public static Animal GetAnimal(string animal, string name, int age, string gender)
        {
            switch (animal)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age, gender);
                case "Tomcat":
                    return new Tomcat(name, age, gender);
                default:
                    return new Animal(" ", 0, " ");
            }
        }
    }
}
