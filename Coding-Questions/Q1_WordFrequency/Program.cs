using System;
using System.Collections.Generic;
using System.Text;

namespace Q1_WordFrequency
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine().ToLower();

            StringBuilder clean = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c) || c == ' ')
                    clean.Append(c);
            }

            string[] words = clean.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }

            Console.WriteLine("\nWord Frequency:");
            foreach (var item in frequency)
                Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
