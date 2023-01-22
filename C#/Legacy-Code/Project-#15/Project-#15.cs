using System;

class program
{
    public static void Main(string[] args)
    {
        DateTime DT1 = new DateTime(2019, 3, 8, 10, 30, 50);
        Console.WriteLine(DT1.ToString());
        Console.WriteLine(DT1.Date.ToString("d"));
        Console.WriteLine(DT1.ToString("g"));
        Console.WriteLine(DT1.ToString("yyyy:MM:dd HH:mm"));

        Console.ReadKey();

    }
}