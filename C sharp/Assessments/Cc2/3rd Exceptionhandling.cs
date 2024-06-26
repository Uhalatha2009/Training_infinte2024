using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc2
{
    class _3rd_Exceptionhandling
    {
        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
            else
            {
                Console.WriteLine("The number is: " + number);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer:");
                int number = int.Parse(Console.ReadLine());


                CheckNumber(number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception: Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
                
            }
            Console.ReadLine();
        }
    }
}




