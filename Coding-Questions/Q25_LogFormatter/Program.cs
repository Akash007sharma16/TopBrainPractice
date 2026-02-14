using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter Log Level: ");
        string level = Console.ReadLine() ?? "";

        Console.Write("Enter Message: ");
        string message = Console.ReadLine() ?? "";

        Console.Write("Enter Module: ");
        string module = Console.ReadLine() ?? "";

        string result = FormatLog(level, message, module);

        Console.WriteLine("\nFormatted Log:");
        Console.WriteLine(result);
    }

    static string FormatLog(string level, string message, string module)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        StringBuilder sb = new StringBuilder(
            $"[{timestamp}] [{level.ToUpper()}] ({module}) - {message}"
        );

        return sb.ToString();
    }
}
