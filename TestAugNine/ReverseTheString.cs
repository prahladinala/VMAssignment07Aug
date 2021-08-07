using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class ReverseTheString
    {
        public static void Main(string[] args) {
            string s;
            Console.WriteLine("Enter the String : ");
            s = Console.ReadLine();
            string[] arr = new string[] { "" };
            arr = s.Split(' ');
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++, Console.Write(" ")) {
                Console.Write(arr[i]);
            }
        }
    }
}
