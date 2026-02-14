using System;

namespace Q5_ReverseWords
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            string result = string.Join(" ", words);

            Console.WriteLine("Reversed Words:");
            Console.WriteLine(result);
        }
    }
}
