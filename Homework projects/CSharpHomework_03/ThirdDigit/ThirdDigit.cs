using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int output = ((input % 1000) - (input % 100))/100;
            if (output == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", output);
            }
        }
    }
}