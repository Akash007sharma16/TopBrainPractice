using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine()!;
        int shift = int.Parse(Console.ReadLine()!);
        shift %= 26;
        string result = "";

        foreach (char ch in text)
        {
            if (char.IsUpper(ch))
                result += (char)('A' + (ch - 'A' + shift + 26) % 26);
            else if (char.IsLower(ch))
                result += (char)('a' + (ch - 'a' + shift + 26) % 26);
            else
                result += ch;
        }

        Console.WriteLine(result);
    }
}
