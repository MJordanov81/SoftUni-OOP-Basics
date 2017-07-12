using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base (firstName, lastName)
        {
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }


        public double WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                else
                {
                    weekSalary = value;
                }
            }
        }

        public new string LastName
        {
            get { return base.LastName; }
            set {
                if (value.Length < 4)
                {
                    throw new ArgumentException(
                        $"Expected length more than 3 symbols! Argument: lastName");
                }
                else
                {
                    base.LastName = value;
                }
            }
        }

        public double CalculateHourlyRate()
        {
            return this.WeekSalary /( 5d * this.WorkHoursPerDay );
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"First Name: {this.FirstName}\n");
            result.Append($"Last Name: {this.LastName}\n");
            result.Append($"Week Salary: {this.WeekSalary:f2}\n");
            result.Append($"Hours per day: {this.WorkHoursPerDay:f2}\n");
            result.Append($"Salary per hour: {this.CalculateHourlyRate():f2}");

            return result.ToString();
        }
    }
}
