using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        StringBuilder sb = new StringBuilder();

        foreach (char ch in input)
        {
            char lower = char.ToLower(ch);
            if (lower != 'a' && lower != 'e' && lower != 'i' && lower != 'o' && lower != 'u')
                sb += ch;
        }

        Console.WriteLine("Result: " + sb.ToString());
    }
}
