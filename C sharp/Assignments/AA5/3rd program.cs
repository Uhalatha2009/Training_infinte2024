using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{
    class _3rd_program
    {
        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public float Salary { get; set; }
            public Employee(int empId, string empName, float salary)
            {
                EmpId = empId;
                EmpName = empName;
                Salary = salary;
            }
            public virtual void Display()
            {
                Console.WriteLine($"Employee ID: {EmpId}");
                Console.WriteLine($"Employee Name: {EmpName}");
                Console.WriteLine($"Salary: {Salary}");
            }
            public class ParttimeEmployee : Employee
            {
                public float Wages { get; set; }
                public ParttimeEmployee(int empId, string empName, float salary, float wages)
                    : base(empId, empName, salary)
                {
                    Wages = wages;
                }
                public override void Display()
                {
                    base.Display();
                    Console.WriteLine($"Wages: {Wages}");
                }
            }
            class Program1
            {
                static void Main()
                {
                    Console.WriteLine("Enter details for Full-time Employee:");
                    Console.Write("Employee ID: ");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Employee Name: ");
                    string empName = Console.ReadLine();
                    Console.Write("Salary: ");
                    float salary = Convert.ToInt32(Console.ReadLine());

                    Employee fullTimeEmployee = new Employee(empId, empName, salary);

                    Console.WriteLine("Enter details for Part-time Employee:");
                    Console.Write("Employee ID: ");
                    empId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Employee Name: ");
                    empName = Console.ReadLine();
                    Console.Write("Salary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Wages: ");
                    float wages = Convert.ToInt32(Console.ReadLine());

                    ParttimeEmployee partTimeEmployee = new ParttimeEmployee(empId, empName, salary, wages);

                    Console.WriteLine("Full-time Employee Details:");
                    fullTimeEmployee.Display();

                    Console.WriteLine("Part-time Employee Details:");
                    partTimeEmployee.Display();
                    Console.ReadLine();
                }
            }
        }
    }
}

           
        
            
        
 
    

        
