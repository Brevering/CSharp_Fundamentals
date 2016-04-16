using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());
            byte P = byte.Parse(Console.ReadLine());
            byte bitVal = byte.Parse(Console.ReadLine());
            ulong mask = 1UL << P;
            ulong bit = (N & mask) >> P;
            if (bit == bitVal)
            {
                Console.WriteLine(N);
            }
            else
            {
                N = N ^ mask;
                Console.WriteLine(N);
            }
        }
    }
}
