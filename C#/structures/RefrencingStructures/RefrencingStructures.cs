namespace Structures;

struct Stemp
{
    public int n;
}

class Ctemp
{
    public int n;
}

class structure
{
    static void ChangeS (Stemp ST)
    {
        ST.n = 0;
    }

    static void ChangeC(Ctemp ST)
    {
        ST.n = 0;
    }

    static void Main(string[] args)
    {
        Stemp NS = new Stemp();
        Ctemp NC = new Ctemp();
        NS.n = 10;
        NC.n = 20;
        ChangeS(NS);
        ChangeC(NC);
        Console.WriteLine($"NS: {NS.n}\nNC: {NC.n}");
        Console.ReadKey();
        
    }
}