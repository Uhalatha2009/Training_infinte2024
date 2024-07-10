using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cc4
{
    class Append_txt
    {
        static void Main()
        {
            Console.WriteLine("write a message do you want to append in the file");
            string fileName = "mytext.txt";
            string textToAppend = Console.ReadLine();

            try
            {
                using (StreamWriter fileStream = File.CreateText(fileName))
                {
                    fileStream.WriteLine("Hello there");
                    fileStream.WriteLine("My name is latha");
                    fileStream.WriteLine("I'm working in infinite computer solution");
                    Console.ReadLine();
                }

                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(textToAppend);
                }

                Console.WriteLine("Text appended to the file successfully.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
