using System;
using System.Collections.Generic;

namespace Q2_LongestSubstring
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            int maxLength = 0;
            string longest = "";

            for (int i = 0; i < input.Length; i++)
            {
                HashSet<char> set = new HashSet<char>();
                string current = "";

                for (int j = i; j < input.Length; j++)
                {
                    if (set.Contains(input[j]))
                        break;

                    set.Add(input[j]);
                    current += input[j];

                    if (current.Length > maxLength)
                    {
                        maxLength = current.Length;
                        longest = current;
                    }
                }
            }

            Console.WriteLine($"Longest Substring: {longest}");
            Console.WriteLine($"Length: {maxLength}");
        }
    }
}
