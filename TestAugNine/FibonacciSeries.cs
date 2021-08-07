using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class FibonacciSeries
    {
        int num1 = 0, num2 = 1, num3;
        public void fib(int num)
        {
            Console.Write(num1);
            Console.Write(" " + num2);
            for (int i = 2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;

            }
        }
        public static void Main(string[] args)
        {
            FibonacciSeries obj = new FibonacciSeries();
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.fib(num);
        }
    }
}
