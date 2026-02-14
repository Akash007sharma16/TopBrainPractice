using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        var freq = new Dictionary<char, int>();

        foreach (char ch in input)
        {
            if (!freq.ContainsKey(ch)) freq[ch] = 0;
            freq[ch]++;
        }

        foreach (char ch in input)
        {
            if (freq[ch] == 1)
            {
                Console.WriteLine(ch);
                return;
            }
        }

        Console.WriteLine("None");
    }
}
