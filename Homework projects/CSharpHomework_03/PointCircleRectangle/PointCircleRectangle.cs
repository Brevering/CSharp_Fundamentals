using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
      
            bool circle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)))) <= 1.5;
            bool rectangle = ((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1));

            if (circle)
            {
                if (rectangle)
                    Console.WriteLine("inside circle inside rectangle");
                else
                    Console.WriteLine("inside circle outside rectangle");
            }
            else
                if (rectangle)
                Console.WriteLine("outside circle inside rectangle");
            else
                Console.WriteLine("outside circle outside rectangle");
        }
    }
}