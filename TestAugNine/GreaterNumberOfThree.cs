using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class GreaterNumberOfThree
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("the first number is greatest");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("the second number is greatest");
            }
            else
            {
                Console.WriteLine("the third number is greatest");
            }


        }
    }
}
