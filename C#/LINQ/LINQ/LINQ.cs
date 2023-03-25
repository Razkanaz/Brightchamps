using System.Linq;

namespace LINQ;

class First
{
    static void Main(string[] args)
    {
        string[] names = { "Adelio", "Bambang", "Safa", "Raul", "zava", "rakha", "Rasya", "syathra", "Caca", "Mala", "Azra", "Barra" };

        var name = from Name in names select Name;

        foreach (var Name in name)
        {
            Console.WriteLine(Name);
        }

        Console.ReadKey();
    }
}