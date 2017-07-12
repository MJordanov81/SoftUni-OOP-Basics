using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;


    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public double Salary
        {
            get { return this.salary; }
            set {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.salary = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                else
                {
                    this.firstName = value;
                }                
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                else
                {
                this.lastName = value;
                }                
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {           
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                else
                {
                this.age = value;
                }               
            }
        }

        public override string ToString()
        {
            return string.Format($"{this.FirstName} {this.LastName} get {this.Salary:f1} leva");
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * bonus / 100;
            }
            else
            {
                this.Salary += this.Salary * bonus / 200;
            }
        }
    }

