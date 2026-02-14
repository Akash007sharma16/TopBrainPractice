using System;

namespace Q8_CaseInsensitiveReplace
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter original string: ");
            string input = Console.ReadLine();

            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            string result = ReplaceIgnoreCase(input, oldWord, newWord);

            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }

        static string ReplaceIgnoreCase(string input, string oldWord, string newWord)
        {
            int index = input.IndexOf(oldWord, StringComparison.OrdinalIgnoreCase);

            while (index >= 0)
            {
                input = input.Remove(index, oldWord.Length)
                             .Insert(index, newWord);

                index = input.IndexOf(oldWord, index + newWord.Length, StringComparison.OrdinalIgnoreCase);
            }

            return input;
        }
    }
}
