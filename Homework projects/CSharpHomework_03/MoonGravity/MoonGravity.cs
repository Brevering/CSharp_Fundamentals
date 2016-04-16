using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", (W * 0.17f));
        }
    }
}