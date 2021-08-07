using System;
using System.Collections.Generic;
using System.Text;

namespace TestAugNine
{
    class CountWordsInString
    {
        public static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("enter the string");
            string line = Console.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("the no of words are:" + count);
        }
    }
}
