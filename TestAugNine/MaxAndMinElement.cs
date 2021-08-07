using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class MaxAndMinElement
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 6, 7, 8, 10 };
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                if (arr[i] < min)
                {
                    min = arr[i];

                }

            }
            Console.WriteLine("the maximum element is:" + max);
            Console.WriteLine("the minimum element is:" + min);
        }
    }
}
