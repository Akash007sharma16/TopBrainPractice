using System;

class Program
{
    static int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x))   // only non-prime numbers
            {
                int s1 = DigitSum(x);
                int s2 = DigitSum(x * x);

                if (s2 == s1 * s1)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
