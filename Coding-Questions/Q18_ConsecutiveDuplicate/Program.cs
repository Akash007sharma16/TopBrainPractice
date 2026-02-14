using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;
        bool found = false;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                Console.WriteLine("Yes");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("No");
    }
}
