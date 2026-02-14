using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFile = "log.txt";
        string targetFile = "error.txt";

        if (File.Exists(sourceFile) == false)
        {
            Console.WriteLine("Log file not found");
            return;
        }

        StreamReader reader = new StreamReader(sourceFile);
        StreamWriter writer = new StreamWriter(targetFile);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            if (line.Contains("ERROR"))
            {
                writer.WriteLine(line);
            }
        }

        reader.Close();
        writer.Close();

        Console.WriteLine("ERROR logs saved to error.txt");
    }
}
