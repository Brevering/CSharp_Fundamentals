using System;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = Math.Sqrt((x * x) + (y * y));

            if (dist <= 2)
            {
                Console.WriteLine("yes {0:0.00}", dist);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", dist);
            }
        }
    }
}