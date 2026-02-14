using System;
using System.Globalization;
using System.Text;
class Program
{
    static void Main()
    {
        string input = " llapppptop bag ";
        string trimmed = input.Trim().ToLower();
        StringBuilder cleaned = new StringBuilder();
        char prev = '\0';

        foreach (char ch in trimmed)
        {
            if (ch != prev)
                cleaned.Append(ch);
            prev = ch;
        }
        string singleSpaced = string.Join(" ",
            cleaned.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries));

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(singleSpaced);

        Console.WriteLine(result);
    }
}
