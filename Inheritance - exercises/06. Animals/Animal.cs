using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Animal : ISound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string Gender
        {
            get { return gender; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value) ||
                    (value != "Female" && value != "Male"))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    gender = value;
                }
                
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    name = value;
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"{this.GetType().Name}\n{this.Name} {this.Age} {this.Gender}\n{this.ProduceSound()}");

            return result.ToString();
        }

        public virtual string ProduceSound()
        {
            return "";
        }
    }
}
