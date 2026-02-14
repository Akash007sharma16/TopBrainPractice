using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine()!;

        StringBuilder sb = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Insert(sb.Length, input[i]);
        }

        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}
