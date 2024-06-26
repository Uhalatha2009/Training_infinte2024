using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA4
{
    class _5th_program
    {
        public class Doctor
        {

            public string regnNo;
            public string name;
            public decimal feesCharged;
            public Doctor(string regnNo, string name, decimal feesCharged)
            {
                this.regnNo = regnNo;
                this.name = name;
                this.feesCharged = feesCharged;
            }
            public string RegnNo
            {
                get { return regnNo; }
                set { regnNo = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public decimal FeesCharged
            {
                get { return feesCharged; }
                set { feesCharged = value; }
            }
            public void Display()
            {
                Console.WriteLine($"Registration Number: {regnNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Fees Charged: {feesCharged}");
            }

            public static void Main()
            {
                Doctor doctor1 = new Doctor("D12378", "Dr.rithu", 150);
                doctor1.Display();
                doctor1.Name = "Dr. riya";
                doctor1.FeesCharged = 200;
                doctor1.Display();
                Console.ReadLine();


                
            }
        }
    }
}
    


    




