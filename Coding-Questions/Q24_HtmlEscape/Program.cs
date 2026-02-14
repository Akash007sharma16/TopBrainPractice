using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        StringBuilder sb = new StringBuilder();

        foreach (char ch in input)
        {
            if (ch == '<') sb += "&lt;";
            else if (ch == '>') sb += "&gt;";
            else if (ch == '&') sb += "&amp;";
            else if (ch == '"') sb += "&quot;";
            else sb += ch;
        }

        Console.WriteLine(sb.ToString());
    }
}
