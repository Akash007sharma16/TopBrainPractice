using System;

namespace Q9_EmailMasking
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            int atIndex = email.IndexOf('@');

            string name = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex);

            string masked = name[0] + new string('*', name.Length - 1) + domain;

            Console.WriteLine("Masked Email:");
            Console.WriteLine(masked);
        }
    }
}
