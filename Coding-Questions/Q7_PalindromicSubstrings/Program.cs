using System;

namespace Q7_PalindromicSubstrings
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Palindromic Substrings:");

            for (int i = 0; i < input.Length; i++)
            {
                Expand(input, i, i);
                Expand(input, i, i + 1);
            }
        }

        static void Expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                Console.WriteLine(s.Substring(left, right - left + 1));
                left--;
                right++;
            }
        }
    }
}
