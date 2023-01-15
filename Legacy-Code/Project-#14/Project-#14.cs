using System;
class program
{

    double Tyear = 2022, Byear = 1900, Gyear = 2010;

    public void Guess(double YEAR)
    {
        string answer;

        int YEEAR = Convert.ToInt32(YEAR);
        Console.WriteLine($"were you born in the year {YEEAR}?");
        Console.Write("before | yes | after: ");
        answer = Console.ReadLine();

        while (answer != "before" && answer != "yes" && answer != "after")
        {
            Console.WriteLine("\nplease answer yes, before, or after\n");

            Console.WriteLine($"were you born in the year {YEEAR}?");
            Console.Write("before|yes|after: ");
            answer = Console.ReadLine();
        }


        if (answer == "before")
        {
            Tyear = YEAR;
            Gyear = Tyear - Math.Round((Tyear - Byear) / 2);
        }
        else if (answer == "after")
        {
            Byear = YEAR;
            Gyear = Byear + Math.Round((Tyear - Byear) / 2);
        }
        else
        {
            Console.WriteLine("Hoorayy!!");
            Console.ReadKey();
            Environment.Exit(3);
        }

    }

    public void the_code()
    {
        while (true)
        {
            Guess(Gyear);
            Console.WriteLine("");
        }
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        program b = new program();
        b.the_code();
    }
}