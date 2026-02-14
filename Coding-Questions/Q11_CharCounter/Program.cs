using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        int upper = 0, lower = 0, digits = 0, spaces = 0, special = 0;

        foreach (char ch in input)
        {
            if (char.IsUpper(ch)) upper++;
            else if (char.IsLower(ch)) lower++;
            else if (char.IsDigit(ch)) digits++;
            else if (char.IsWhiteSpace(ch)) spaces++;
            else special++;
        }

        Console.WriteLine($"Uppercase: {upper}");
        Console.WriteLine($"Lowercase: {lower}");
        Console.WriteLine($"Digits: {digits}");
        Console.WriteLine($"Spaces: {spaces}");
        Console.WriteLine($"Special: {special}");
    }
}
