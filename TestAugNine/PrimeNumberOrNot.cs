using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class PrimeNumberOrNot
    {
        public void prime(int num)
        {
            int f = 0;
            int m = num / 2;
            for (int i = 2; i < m; i++)
            {
                if (num % i == 0)
                {
                    f = 1;
                    break;
                }
            }
            if (num == 1)
            {
                Console.WriteLine("1 is neither prime nor composite");
            }
            else
            {
                if (f == 0)
                {
                    Console.WriteLine(num + " is a prime number");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number");
                }
            }


        }
        public static void Main(string[] args)
        {
            PrimeNumberOrNot obj = new PrimeNumberOrNot();
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.prime(num);
        }
    }
}
