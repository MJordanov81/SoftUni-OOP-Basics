using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public Employee(string name, double salary, string position, string department, string email)
            :this(name, salary, position, department)
        {
            this.email = email;
        }

        public Employee(string name, double salary, string position, string department, int age)
            : this(name, salary, position, department)
        {
            this.age = age;
        }

        public Employee(string name, double salary, string position, string department, string email, int age)
            : this(name, salary, position, department, email)
        {
            this.age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return string.Format($"{this.Name} {this.Salary:f2} {this.Email} {this.Age}");
        }
    }
}
