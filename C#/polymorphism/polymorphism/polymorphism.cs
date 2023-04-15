namespace PolyMorph;

class PolyMorph
{

    void combine (int a, int b)
    {
        Console.WriteLine($"Combine 2 Numbers: {a + b}");
    }

    void combine(string a, string b)
    {
        Console.WriteLine($"Combine 2 Words: {a + b}");
    }

    static void Main(string[] args)
    {
        PolyMorph m = new PolyMorph();
        m.combine ("3", "5");
        m.combine (3,5);

        Console.ReadKey();
    }
}