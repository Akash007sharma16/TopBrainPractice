using System;
using System.Collections.Generic;

namespace Q4_AnagramChecker
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine().ToLower();

            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine().ToLower();

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagram");
                return;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s1)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }

            foreach (char c in s2)
            {
                if (!map.ContainsKey(c) || map[c] == 0)
                {
                    Console.WriteLine("Not Anagram");
                    return;
                }
                map[c]--;
            }

            Console.WriteLine("Anagram");
        }
    }
}
