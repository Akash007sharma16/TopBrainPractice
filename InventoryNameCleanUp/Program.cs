
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        // Step 1: Remove extra spaces
        input = input.Trim();
        while (input.Contains("  "))
        {
            input = input.Replace("  ", " ");
        }

        // Step 2: Remove consecutive duplicate characters
        StringBuilder cleaned = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || input[i] != input[i - 1])
            {
                cleaned.Append(input[i]);
            }
        }

        // Step 3: Convert to Title Case
        string[] words = cleaned.ToString().Split(' ');
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                result.Append(char.ToUpper(word[0]));
                result.Append(word.Substring(1).ToLower());
                result.Append(" ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}
