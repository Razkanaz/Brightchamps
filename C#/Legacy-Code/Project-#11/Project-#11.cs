using System;

class program
{
    public static void Main(string[] args)
    {
        int ctr, sum, samount;

        while (true)
        {
            ctr = 0;
            sum = 0;

            samount = askint("pick a number: ");
            while (ctr < samount)
            {
                if (isprime(ctr))
                {
                    sum += ctr;
                }
                ctr += 2;
            }

            Console.WriteLine($"the sum of al prime numbers under {samount} is: {sum}");
        }
    }

    public static bool isprime(double n)
    {

        double x = Math.Sqrt(n);

        if (x == 1) return false;
        if (x == 2) return true;

        for (int i = 2; i < n; i++)
        {
            if (i == n)
            {
                return true;
            }
            else if (n % i == 0)
            {
                return false;
            }

        }

        return true;
    }

    public static int askint(string text)
    {
        Console.Write(text);
        string v = Console.ReadLine();
        while (int.TryParse(v, out _) == false)
        {
            Console.WriteLine("");
            Console.WriteLine("please enter a number");
            Console.Write(text);
            v = Console.ReadLine();
        }
        return Convert.ToInt32(v);
    }
}