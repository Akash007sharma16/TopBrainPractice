using System;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        string s1=Console.ReadLine();
        string s2=Console.ReadLine();
        HashSet<char> hs=new HashSet<char>();
        foreach(var c in s2) hs.Add(char.ToLower(c));
        StringBuilder str=new StringBuilder();
        foreach(char i in s1)
        {
            char lower=char.ToLower(i);
            if(!hs.Contains(lower)) str.Append(lower);
        }
        StringBuilder res=new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (i == 0 || str[i] != str[i - 1])
            {
                res.Append(str[i]);
            }
        }
        Console.WriteLine(res.ToString());
    }
}
