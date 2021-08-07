using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class PositiveIntegerPrimeOrNot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int m = num / 2;
            int count = 0;
            for (int i = 2; i < m; i++)
            {
                if (num % i == 0)
                {
                    count = 1;
                }
            }
            if (num == 1)
            {
                Console.WriteLine("1 is neither prime nor composite");
            }
            if (count == 0)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }

        }
    }
}
