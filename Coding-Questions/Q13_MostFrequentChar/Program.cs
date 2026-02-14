using System;
using System.Collections.Generic;
using System.Linq;

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

        char result = freq.OrderByDescending(x => x.Value).First().Key;
        Console.WriteLine(result);
    }
}
