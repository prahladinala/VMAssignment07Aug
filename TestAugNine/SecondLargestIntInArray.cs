using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class SecondLargestIntInArray
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[4] { 3, 1, 2, 4 };
            Array.Sort(arr);
            int n = arr.Length;
            Console.WriteLine("the second largest number is:" + arr[n - 2]);
        }
    }
}
