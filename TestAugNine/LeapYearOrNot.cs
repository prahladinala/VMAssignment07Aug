using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class LeapYearOrNot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not a leap year");
            }
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
