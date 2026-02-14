using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine()!;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            sb = sb.Insert(sb.Length, input[i]);

            if (i < input.Length - 1)
                sb = sb.Insert(sb.Length, '*');
        }

        Console.WriteLine(sb.ToString());
    }
}
