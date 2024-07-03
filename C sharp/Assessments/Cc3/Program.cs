using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Cc3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of matches: ");
            int num_matches = Convert.ToInt32(Console.ReadLine());

            Crickets.Pointscalculation(num_matches);
            Console.ReadLine();
            Console.WriteLine("+++++++++++++++2nd program+++++++++++++++++++++");
            Box.Result();
            Console.ReadLine();
        }

        class Crickets
        {
            public static void Pointscalculation(int no_of_matches)
            {
                int[] scores = new int[no_of_matches];
                int total_sum = 0;

                for (int i = 0; i < no_of_matches; i++)
                {
                    Console.WriteLine($"Enter score for match {i + 1}: ");
                    scores[i] = Convert.ToInt32(Console.ReadLine());
                    total_sum += scores[i];
                }

                int average = total_sum / no_of_matches;

                Console.WriteLine($"Total Sum of scores: {total_sum}");
                Console.WriteLine($"Average score: {average}");
                Console.ReadLine();

            }
        }
    }
    public class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box Add(Box box1, Box box2)
        {
            int Length3 = box1.Length + box2.Length;
            int Breadth3 = box1.Breadth + box2.Breadth;
            return new Box(Length3, Breadth3);
        }
        public void Show()
        {
            Console.WriteLine($" Length of Box 3: {Length}, Breadth of box 3: {Breadth}");
        }
        public static void Result()
        {
            Console.WriteLine("Enter dimensions for Box 1:");
            Console.Write("Length: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Breadth: ");
            int breadth1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter dimensions for Box 2:");
            Console.Write("Length: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Breadth: ");
            int breadth2 = Convert.ToInt32(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Box 3 Dimensions:");
            box3.Show();
        }
    }
}






