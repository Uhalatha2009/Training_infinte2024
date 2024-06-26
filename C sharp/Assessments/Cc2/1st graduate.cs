using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc2
{
    class _1st_graduate
    {
        public abstract class Student
        {

            public string name;
            public int studentId;
            public double grade;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int StudentId
            {
                get { return studentId; }
                set { studentId = value; }
            }

            public double Grade
            {
                get { return grade; }
                set { grade = value; }
            }
            protected Student(string name, int studentId, double grade)
            {
                this.name = name;
                this.studentId = studentId;
                this.grade = grade;
            }
            public abstract bool IsPassed();
        }
        public class Undergraduate : Student
        {
            public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
            {
            }
            public override bool IsPassed()
            {
                return Grade > 70.0;
            }
        }
        public class Graduate : Student
        {
            public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
            {
            }
            public override bool IsPassed()
            {
                return Grade > 80.0;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Undergraduate undergrad = new Undergraduate("rithu", 141, 74.0);
                Console.WriteLine($"{undergrad.Name} with Student ID {undergrad.StudentId} has {(undergrad.IsPassed() ? "passed" : "not passed")}.");

                Graduate grad = new Graduate("riya", 221, 84.0);
                Console.WriteLine($"{grad.Name} with Student ID {grad.StudentId} has {(grad.IsPassed() ? "passed" : "not passed")}.");
                Console.ReadKey();
            }
        }
    }
}






    
