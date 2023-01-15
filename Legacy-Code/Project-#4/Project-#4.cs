using System;

class program
{
    public static void Main(string[] args)
    {

        Console.Write("pick a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("pick another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} MOD {1} = {2}", num1, num2, num1 % num2);

        Console.ReadKey();
    }
}