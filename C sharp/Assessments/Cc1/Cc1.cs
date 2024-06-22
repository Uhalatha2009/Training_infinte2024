using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc1
{
    class Program
    {
        static void Main(string[] args)

        {
         /* Console.WriteLine(test("python", 1));
             Console.WriteLine(test("python", 0));
             Console.WriteLine(test("python", 4));
             Console.ReadLine();
         }
         public static string test(string str, int n)
         {
            return str.Remove(n, 1);
             Console.ReadKey();

            Console.WriteLine("++++++++++++++++++++++++++:");*/

             Console.WriteLine("enter the number.");
              int number = int.Parse(Console.ReadLine());

              for(int i=0;i<=10;i++)
              {
                  int result = number * i;
                  Console.WriteLine($"{number}*{i}={result}");
              }
              Console.ReadLine();

           //  Console.WriteLine("++++++++++++++++++:");


         /*  Console.WriteLine("enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third integer:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine($"the first number is the greatest among three: {num1}");
                }
                else
                {
                    Console.WriteLine("the third number is the greatest among three:");

                }
            }
            else if(num2>num3)
            {
                Console.WriteLine($"the second number is the greatest among three:{num2}");
            }
            else
            {
                Console.WriteLine($"the third number is the greatest among three:{num3}");
                Console.ReadKey();*/
            }














        }
    }


