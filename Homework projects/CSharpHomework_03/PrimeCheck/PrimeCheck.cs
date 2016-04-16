using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int checker = 2;
            if (N > 1)
            {
                while ((checker < N) & (N % checker != 0))
                {
                    checker++;
                }
                if (checker == N)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}