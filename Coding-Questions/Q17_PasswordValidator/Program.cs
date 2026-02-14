using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine()!;
        bool upper = false, lower = false, digit = false, special = false;

        foreach (char ch in password)
        {
            if (char.IsUpper(ch)) upper = true;
            else if (char.IsLower(ch)) lower = true;
            else if (char.IsDigit(ch)) digit = true;
            else special = true;
        }

        if (password.Length >= 8 && upper && lower && digit && special)
            Console.WriteLine("Strong");
        else
            Console.WriteLine("Weak");
    }
}
