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
        if (num <= 1) return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x))
            {
                int sx = DigitSum(x);
                int sxx = DigitSum(x * x);

                if (sxx == (sx * sx))
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
