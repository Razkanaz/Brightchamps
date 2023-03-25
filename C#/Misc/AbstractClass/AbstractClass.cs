namespace Abstract;

abstract class player
{
    public abstract string name { get; set; }

}

class jared:player
{
    public override string name
    {
        get; set;
    }
}

class main
{
    static void Main(string[] args)
    {
        jared name = new jared();
        name.name = "jared";

        Console.WriteLine(name.name);

        Console.ReadKey();
    }
}