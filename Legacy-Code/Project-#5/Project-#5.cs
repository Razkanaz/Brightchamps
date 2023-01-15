using System;

class program
{
    public static void Main(string[] args)
    {
        int[] multiplications = new int[10];
        Console.Write("find the multiplication of a number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            multiplications.Append(i * x);
            Console.WriteLine(i * x);
        }

        writearray(multiplications, "", "");
        Console.ReadKey();
    }

    public static string writearray(int[] anf, string prefix, string postfix)
    {

        for (int i = 0; i < anf.Length; i++)
        {
            Console.WriteLine(prefix + anf[i] + postfix);
        }

        return "";
    }
}