using System;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            ulong P = ulong.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());
            ulong mask = 1UL << N;
            ulong bit = (P & mask) >> N;
            Console.WriteLine(bit);
        }
    }
}
