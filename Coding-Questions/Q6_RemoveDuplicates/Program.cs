using System;
using System.Collections.Generic;

namespace Q6_RemoveDuplicates
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            HashSet<char> seen = new HashSet<char>();
            string result = "";

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result += c;
                }
            }

            Console.WriteLine("After Removing Duplicates:");
            Console.WriteLine(result);
        }
    }
}
