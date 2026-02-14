using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        string result = "";

        foreach (char ch in input)
        {
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        Console.WriteLine(result);
    }
}
