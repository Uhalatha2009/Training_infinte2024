using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_practice
{
    class Distance
    {
        public int dist1;


        public Distance(int d = 0)
        {
            dist1 = d;
        }

        public static Distance operator ++(Distance dis)
        {
            dis.dist1++;
            return dis;
        }

        // Overload the + operator
        public static Distance operator +(Distance dis1, Distance dis2)
        {
            Distance temp = new Distance();
            temp.dist1 = dis1.dist1 + dis2.dist1;
            return temp;
        }
    }

    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance(50);
            Distance d2 = new Distance(80);

            Distance totalDistance = d1 + d2;
            Console.WriteLine("The overall Distance is {0}", totalDistance.dist1);

            totalDistance = d1++;
            Console.WriteLine("The overall Distance after post-increment is {0}", totalDistance.dist1);

            Console.Read();
        }
    }




}



