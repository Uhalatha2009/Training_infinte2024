using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("the two integers are equal:");

            }
            else
            {
                Console.WriteLine("the two integers are not equal:");
                Console.ReadLine();


               Console.WriteLine("+++++++++++++++++++++++++++++:");



               Console.WriteLine("enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num > 0)
                {
                    Console.WriteLine("given number is positive:");
                }
                else
                {
                    Console.WriteLine("given number is negative:");
                Console.ReadKey();*/

                int num1, num2, temp;
                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nBefore swapping :num1 = {num1}, num2 = {num2}");

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine($"\nAfter swapping );
                

            }

            }
    }
}
