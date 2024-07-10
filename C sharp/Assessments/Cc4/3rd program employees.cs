using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc4
{
    public class Employee : IComparable<Employee>
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public Employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }

        public int CompareTo(Employee other)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {FirstName} {LastName}, Title: {Title}, DOB: {DOB.ToShortDateString()}, DOJ: {DOJ.ToShortDateString()}, City: {City}";
        }
    }
    public class Programs
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>
        {
            new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"),
            new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"),
            new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"),
            new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"),
            new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"),
            new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"),
            new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"),
            new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"),
            new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"),
            new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune")
        };

            Console.WriteLine("Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("\nDetails of employees not in Mumbai:");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine(emp.ToString());
            }
            var assistantManagers = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("\nDetails of employees with title AsstManager:");
            foreach (var emp in assistantManagers)
            {
                Console.WriteLine(emp.ToString());
            }
            var employeesWithLastNameStartingWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("\nDetails of employees whose last name starts with S:");
            foreach (var emp in employeesWithLastNameStartingWithS)
            {
                Console.WriteLine(emp.ToString());
                Console.ReadLine();
            }
        }
    }
}

