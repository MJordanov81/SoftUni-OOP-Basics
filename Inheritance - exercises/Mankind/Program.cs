using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Program
    {
        public static void Main()
        {
            var inputStudent = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var firstNameStudent = inputStudent[0];
            var lastNameStudent = inputStudent[1];
            var facultyNumber = inputStudent[2];
            var inputWorker = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var firstNameWorker = inputWorker[0];
            var lastNameWorker = inputWorker[1];
            var weekSalary = double.Parse(inputWorker[2]);
            var workHoursPerDay = double.Parse(inputWorker[3]);

            Student student;
            Worker worker;

            try
            {
                student = new Student(firstNameStudent, lastNameStudent, facultyNumber);
                worker = new Worker(firstNameWorker, lastNameWorker, weekSalary, workHoursPerDay);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
            Console.WriteLine();
        }
    }
}
