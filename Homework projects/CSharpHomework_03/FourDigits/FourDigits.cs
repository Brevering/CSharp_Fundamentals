using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int digit4 = input % 10;
            int digit3 = ((input % 100) - digit4) / 10;
            int digit2 = ((input % 1000) - digit3) / 100;
            int digit1 = input / 1000;

            Console.WriteLine(digit1 + digit2 + digit3 + digit4);
            Console.WriteLine("{3}{2}{1}{0}", digit1, digit2, digit3, digit4);
            Console.WriteLine("{3}{0}{1}{2}", digit1, digit2, digit3, digit4);
            Console.WriteLine("{0}{2}{1}{3}", digit1, digit2, digit3, digit4);
        }
    }
}