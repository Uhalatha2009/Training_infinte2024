using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{
    class _4th_program
    {
        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }
        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine($"Day Scholar Details:");
                Console.WriteLine($"Student ID: {StudentId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine("Type: Day Scholar");
            }
        }
        public class Resident : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine($"Resident Details:");
                Console.WriteLine($"Student ID: {StudentId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine("Type: Resident");
            }
        }
        class Program1
        {
            static void Main()
            {
                Dayscholar dayScholar = new Dayscholar();
                Console.WriteLine("Enter details for Day Scholar:");
                Console.Write("Student ID: ");
                dayScholar.StudentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                dayScholar.Name = Console.ReadLine();
                Resident resident = new Resident();
                Console.WriteLine("\nEnter details for Resident:");
                Console.Write("Student ID: ");
                resident.StudentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                resident.Name = Console.ReadLine();
                Console.WriteLine();
                dayScholar.ShowDetails();
                Console.WriteLine();
                resident.ShowDetails();
                Console.ReadLine();
            }
        }
    }
}
