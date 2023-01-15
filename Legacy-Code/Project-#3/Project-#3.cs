using System;

class program
class program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("choose a number: ");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("the nearest prime number is " + npn(n));
            Console.WriteLine("\n");
        }
    }

    public static long npn(long n)
    {

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) { n++; i = 2; }
        }
        return n;
    }
}