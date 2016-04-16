using System;

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string result = "false";
            if (Convert.ToBoolean((number % 5) == 0) & Convert.ToBoolean((number % 7) == 0))
            {
                result = "true";
            }
            Console.WriteLine("{0} {1}", result, number);
        }
    }
}