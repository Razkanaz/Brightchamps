using System;
class program
{
    public static void Main(string[] args)
    {
        Console.Title = "the max";
        double num1, num2, num3, num1old;
        num1 = askdouble("(X + Y) * Z \n Pick X: ");
        Console.WriteLine("");
        num1old = 0 - num1;
        num2 = askdouble($"({num1} + Y) * Z \n Pick Y: ");
        Console.WriteLine("");
        num3 = 10;
        while (num3 >= 1)
        {
            num3 = askdouble($"({num1} + {num2}) * Z \n Pick Z (must be under 1): ");
            Console.WriteLine("");
        }
        while (num1 != num1old)
        {
            Console.WriteLine($"({num1}+{num2})*{num3} = {(num1 + num2) * num3}");
            num1old = num1;
            num1 = (num1 + num2) * num3;
        }
        Console.ReadKey();
    }
    public static double askdouble(string text)
    {
        Console.Write(text);
        string v = Console.ReadLine();
        while (double.TryParse(v, out _) == false)
        {
            Console.WriteLine("");
            Console.WriteLine("please enter a number");
            Console.Write(text);
            v = Console.ReadLine();
        }
        return Convert.ToDouble(v);
    }
}