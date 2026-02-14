using System;
using System.Collections.Generic;

namespace Q10_BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter expression: ");
            string input = Console.ReadLine();

            bool isBalanced = CheckBalanced(input);

            Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
        }

        static bool CheckBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
