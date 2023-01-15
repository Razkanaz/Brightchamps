using System;

class program
{
    public static void Main(string[] args)
    {
        int n = 0, sum = 0;
        Console.Write("write a 2 or more digit number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if ((Convert.ToString(n)).Length < 2)
        {
            Console.WriteLine("i said MORE THAN 2 YOU BLOODY IDIOT");
            Console.ReadKey();
            return;
        }

        while (n != 0)
        {
            sum += n % 10;
            n = n / 10;
        }

        Console.WriteLine($"the sum of all the digits are {sum}");
        Console.ReadKey();
    }
}