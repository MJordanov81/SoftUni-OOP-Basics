using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (!IsFacultyNumberValid(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                else
                {
                    facultyNumber = value;
                }
            }
        }

        private bool IsFacultyNumberValid(string facutyNumber)
        {
            string numberPattern = @"^([0-9a-zA-Z]{5,10})$";

            var regex = new Regex(numberPattern);

            var match = regex.Match(facutyNumber);

            if (match.Success)
            {
                return true;
            }
                
            return false;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"First Name: {this.FirstName}\n");
            result.Append($"Last Name: {this.LastName}\n");
            result.Append($"Faculty number: {this.FacultyNumber}");

            return result.ToString();
        }
    }
}
