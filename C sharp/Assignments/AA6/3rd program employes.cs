using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA6
{
    class _3rd_program_employes
    {
        class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string EmpCity { get; set; }
            public decimal EmpSalary { get; set; }
        }
        static void Main()
        {
            Employee[] employees = new Employee[]
            {
            new Employee { EmpId = 1, EmpName = "rithu", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 2, EmpName = "riya", EmpCity = "Mumbai", EmpSalary = 58000 },
            new Employee { EmpId = 3, EmpName = "sweety", EmpCity = "Delhi", EmpSalary = 43000 },
            new Employee { EmpId = 4, EmpName = "chitty", EmpCity = "Bangalore", EmpSalary = 48000 },
            new Employee { EmpId = 5, EmpName = "priya", EmpCity = "Chennai", EmpSalary = 63000 }
            };

            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);

            Console.WriteLine("\nEmployees with Salary > 45000:");
            DisplayEmployeesWithSalaryAbove(employees, 45000);

            Console.WriteLine("\nEmployees from Bangalore:");
            DisplayEmployeesFromCity(employees, "Bangalore");

            Console.WriteLine("\nEmployees sorted by Name (Ascending):");
            Array.Sort(employees, (x, y) => string.Compare(x.EmpName, y.EmpName));
            DisplayEmployees(employees);
        }
        static void DisplayEmployees(Employee[] employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                Console.ReadLine();
            }
        }
        static void DisplayEmployeesWithSalaryAbove(Employee[] employees, decimal salaryThreshold)
        {
            foreach (var emp in employees)
            {
                if (emp.EmpSalary > salaryThreshold)
                {
                    Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                    Console.ReadLine();
                }
            }
        }


        static void DisplayEmployeesFromCity(Employee[] employees, string city)
        {
            foreach (var emp in employees)
            {
                if (emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                    Console.ReadLine();
                }
            }
        }
    }
}



