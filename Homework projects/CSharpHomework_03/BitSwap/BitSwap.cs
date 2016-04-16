using System;

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte q = byte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= k; i++)
            {
                ulong maskP = (1UL << p); //mask for bit p
                ulong maskQ = (1UL << q); //mask for bit q
                ulong bitP = (n & maskP);//get bit p
                ulong bitQ = (n & maskQ);//get bit q
                if (p < q)   //move bits to new place
                {
                    bitP <<= (q - p);
                    bitQ >>= (q - p);
                }
                else
                {
                    bitP >>= (p - q);
                    bitQ <<= (p - q);
                }

                n &= ~(maskP | maskQ);//wipe out bits at positions p & q
                n |= bitP;
                n |= bitQ;//insert new bits
                p++;
                q++;
            }
            Console.WriteLine(n);
        }
    }
}