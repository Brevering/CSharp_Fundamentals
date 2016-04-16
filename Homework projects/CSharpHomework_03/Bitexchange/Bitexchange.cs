using System;

namespace Bitexchange
{
    class Bitexchange
    {
        static void Main()
        {
            ulong inputNbr = ulong.Parse(Console.ReadLine());//Receive the number

            ulong mask1 = (7UL << 3); //mask for bits 3, 4, 5
            ulong mask2 = (7UL << 24);//mask for bits 24, 25, 26
            ulong bits1 = (inputNbr & mask1);//get bits 3, 4, 5
            ulong bits2 = (inputNbr & mask2);//get bits 24, 25, 26
            bits1 = bits1 << 21; //move bits to new place
            bits2 = bits2 >> 21; //move bits to new place
            ulong tempNbr = inputNbr & ~(mask1 | mask2);//wipe out bits at positions 3, 4, 5, 24, 25, 26

            tempNbr |= bits1; // place new bits at positions 24, 25, 26
            tempNbr |= bits2; // place new bits at positions 3, 4, 5

            Console.WriteLine(tempNbr);
        }
    }
}