using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    age = value;
                }

            }
        }

        public virtual string Name
        {
            get { return name; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Name: {this.name}, Age: {this.Age}");

            return result.ToString();
        }
    }
}
