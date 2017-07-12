using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Company_Roster
{
    class StartUp
    {
        private static Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

        static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                switch (tokens.Length)
                {
                    case 4: Employee currentEmployee = new Employee(tokens[0], double.Parse(tokens[1]), tokens[2], tokens[3]);
                        AddEmployee(currentEmployee);
                        break;
                    case 5:
                        int age;
                        var isAge = int.TryParse(tokens[4], out age);
                        if (isAge)
                        {
                            currentEmployee = new Employee(tokens[0], double.Parse(tokens[1]), tokens[2], tokens[3],
                                age);
                            AddEmployee(currentEmployee);
                        }
                        else
                        {
                            currentEmployee = new Employee(tokens[0], double.Parse(tokens[1]), tokens[2], tokens[3],
                                tokens[4]);
                            AddEmployee(currentEmployee);
                        }
                        break;
                    case 6:
                        currentEmployee = new Employee(tokens[0], double.Parse(tokens[1]), tokens[2], tokens[3],
                            tokens[4], int.Parse(tokens[5]));
                        AddEmployee(currentEmployee);
                        break;
                }
            }

            employees.OrderByDescending(department => department.Value.Average(x => x.Salary)).Take(1).ToList().ForEach(
                department =>
                {
                    Console.WriteLine($"Highest Average Salary: {department.Key}");

                    department.Value.OrderByDescending(employee => employee.Salary).ToList().ForEach(employee =>
                    {
                        Console.WriteLine(employee.ToString());
                    });
                });

        }

        private static void AddEmployee(Employee currentEmployee)
        {
            if (!employees.ContainsKey(currentEmployee.Department))
            {
                employees[currentEmployee.Department] = new List<Employee>();
            }

            employees[currentEmployee.Department].Add(currentEmployee);
        }
    }
}
