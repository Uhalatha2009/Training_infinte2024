using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_19date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("integer1:+++++++++++++++++:");
            integers.integer1();
            Console.ReadLine();
            Console.WriteLine("integer2:+++++++++++++++++:");
            integers.integer2();
            Console.ReadLine();


            Console.WriteLine("Array1:+++++++++++++++++:");

            Arrays.Array1();
            Console.ReadLine();
            Console.WriteLine("Array2:+++++++++++++++++:");
            Arrays.Array2();
            Console.ReadLine();
            Console.WriteLine("Array3:+++++++++++++++++:");
            Arrays.Array3();
            Console.ReadLine();

            Console.WriteLine("++++++++++++++++++++++++++++:");
            strings.string1();
            Console.ReadLine();
            Console.WriteLine("+++++++++++++++++:");
            strings.string2();
            Console.ReadLine();
            Console.WriteLine("+++++++++++++++++++++++:");
            strings.string3();
            Console.ReadLine();
        }

         class integers
        {
           
             public static void integer1()
            {
                Console.WriteLine("Enter the Number(1-7):");
                int dayNumber = Convert.ToInt32(Console.ReadLine());

                if (dayNumber == 1)
                {
                    Console.WriteLine("Monday");
                    Console.ReadLine();

                }
                else if (dayNumber == 2)
                {
                    Console.WriteLine("Tuesday");
                    Console.ReadLine();

                }
                else if (dayNumber == 3)
                {
                    Console.WriteLine("Wednesday");
                    Console.ReadLine();
                }
                else if (dayNumber == 4)
                {
                    Console.WriteLine("Thursday");
                    Console.ReadLine();
                }
                else if (dayNumber == 5)
                {
                    Console.WriteLine("Friday");
                    Console.ReadLine();
                }
                else if (dayNumber == 6)
                {
                    Console.WriteLine("Saturday");
                    Console.ReadLine();
                }
                else if (dayNumber == 7)
                {
                    Console.WriteLine("Sunday");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("not a week day");
                    Console.ReadLine();
                }


            }

             public static void integer2()
            {
                //Console.WriteLine("+++++++++++++++++++++++++:");
                Console.WriteLine("enter the first integer:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second integer:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int n3 = num1 + num2;

                if (num1 == num2)
                {
                    Console.WriteLine($"CalucateResult: {n3 * 3}");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"CalucateResult: {n3}");
                    Console.ReadKey();
                }
            }
        }

    }
        class strings
        {
            public static void string1()
            {
                Console.WriteLine("enter a string ");
                String word = Console.ReadLine();
                Console.WriteLine("Lenth of given word=" + word.Length);
                Console.ReadLine();
            }
            public static void string2()
            {
                Console.WriteLine("Enter a string1");
                string str1 = Console.ReadLine();
                Console.WriteLine("Enter a string2");
                string str2 = Console.ReadLine();
                if (str1 == str2)
                {
                    Console.WriteLine("Both are same");
                }
                else
                {
                    Console.WriteLine("Both are not same");
                }
            }
            public static void string3()
            {
                Console.WriteLine("enter a /string");
                string s = Console.ReadLine();
                string reverse = "";
                for (int i = 0; i < s.Length; i++)
                {
                    reverse = s[i] + reverse;
                }

                Console.WriteLine("eafter reversing " + reverse);
            }
        }
    }
class Arrays
{
    public static void Array1()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine(arr1.Max());
        Console.WriteLine(arr1.Min());
        Console.WriteLine(arr1.Average());
    }
    public static void Array2()
    {
        Console.Write("Enter the size of an array ");
        //Console.WriteLine();
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[size];
        Console.WriteLine("Enter the {0} elements :", size);
        for (int i = 0; i < size; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Sum is :");
        Console.WriteLine(arr2.Sum());

        Console.WriteLine("Average is :");
        Console.WriteLine(arr2.Average());

        Console.WriteLine("Minimum is :");
        Console.WriteLine(arr2.Min());

        Console.WriteLine("Maximum is is :");
        Console.WriteLine(arr2.Max());

        Array.Sort(arr2);
        Console.WriteLine("Ascending Order is :");
        foreach (int i in arr2)
        {
            Console.Write($" {i} ");
        }
        Console.WriteLine();

        Array.Reverse(arr2);
        Console.WriteLine("Descending Order is :");
        foreach (int i in arr2)
        {
            Console.Write($" {i} ");

        }
    }
    
 
        public static void Array3()
        {
            Console.WriteLine("Previous array is: {1, 2, 3, 4, 5}");
            int[] Array3_old = { 1, 2, 3, 4, 5};

            int[] Array3_new =  new int[Array3_old.Length];
            for (int i = 0; i < Array3_old.Length; i++)
            {

                Array3_new[i] =  Array3_old[i];
            }
        

        Console.WriteLine("New array is :");
            for (int i = 0; i < Array3_new.Length; i++)
            {

                Console.Write(Array3_new[i] + " ");
            }
        }

    }




        
    
    
           
            

    

 
















































































