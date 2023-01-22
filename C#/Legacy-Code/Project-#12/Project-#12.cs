using System;

class program
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        FileInfo f = new FileInfo(a);
        Console.WriteLine(f.Length.ToString());
        Console.ReadKey();
    }
}