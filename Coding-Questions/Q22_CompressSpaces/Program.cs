using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        StringBuilder sb = new StringBuilder();
        bool spaceFound = false;

        foreach (char ch in input)
        {
            if (ch == ' ')
            {
                if (!spaceFound)
                {
                    sb += ch;
                    spaceFound = true;
                }
            }
            else
            {
                sb += ch;
                spaceFound = false;
            }
        }

        Console.WriteLine("Result: " + sb.ToString());
    }
}
