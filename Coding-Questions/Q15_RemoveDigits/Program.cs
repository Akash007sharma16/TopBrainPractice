using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        string result = "";

        foreach (char ch in input)
            if (!char.IsDigit(ch))
                result += ch;

        Console.WriteLine(result);
    }
}
