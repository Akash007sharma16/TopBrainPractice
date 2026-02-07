using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        // Store characters of second word (case-insensitive)
        HashSet<char> secondSet = new HashSet<char>();
        foreach (char ch in secondWord)
        {
            secondSet.Add(char.ToLower(ch));
        }

        // Task 1: Remove common consonants
        StringBuilder filtered = new StringBuilder();
        foreach (char ch in firstWord)
        {
            char lower = char.ToLower(ch);

            if (IsVowel(lower) || !secondSet.Contains(lower))
            {
                filtered.Append(ch);
            }
        }

        // Task 2: Remove consecutive duplicate characters
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }
}
