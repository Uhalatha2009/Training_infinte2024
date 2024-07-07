using System;
using System.Collections.Generic;

namespace AA6
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter the number:");
            Console.ReadLine();
            int[] numbers = { 7, 2, 30 };
            foreach (int number in numbers)
            {
                int square = number * number;
                if (square > 20)
                {
                    Console.WriteLine($"{number} - {square}");
                }
            }
            Console.WriteLine("---------------------2nd program:");

            Console.WriteLine("enter the strings:");
            Console.ReadLine();
            List<string> words = new List<string> { "mum", "amsterdam", "bloom" };
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char firstChar = char.ToLower(word[0]);
                    bool startsWithA = (firstChar == 'a');
                    char lastChar = char.ToLower(word[word.Length - 1]);
                    bool endsWithM = (lastChar == 'm');

                    if (startsWithA && endsWithM)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
