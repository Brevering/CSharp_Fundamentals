﻿using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            uint bit = (input & mask) >> 3;
            Console.WriteLine(bit);
        }
    }
}
