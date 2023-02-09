namespace Structures;

struct Register
{
    private int number;
    
    public int n
    {
        get
        {
            return number;
        }
        set
        {
            if (value%2 == 0)
            {
                number = value;
            }
        }
    }

    public void Pr ()
    {
        Console.WriteLine($"number = {number}");
    }
}

class structures
{
    static void Main(string[] args)
    {
        Register r = new Register();

        r.n = 50;
        r.Pr();
        Console.ReadKey();
    }
}