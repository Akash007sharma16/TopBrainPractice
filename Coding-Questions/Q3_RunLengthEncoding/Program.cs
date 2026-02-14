using System;

namespace Q3_RunLengthEncoding
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string result = "";
            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    result += input[i] + count.ToString();
                    count = 1;
                }
            }

            Console.WriteLine("Encoded String: " + result);
        }
    }
}
