using System.Linq;

namespace LINQ;

class SUM
{
    static void Main(string[] args)
    {
        int[] Numbers = { 1, 3, 6, 5, 3, 3, 8, 4, 5, 8, 4, 6, 7, 7, 9, 3, 6, 2, 4, 2, 4, 6, 8, 3, 3, 6, 5, 3, 4, 8, 1, 3 };

        var n = from N in Numbers group N by N into Y select Y;

        foreach (var item in n)
        {
            Console.WriteLine($"Number {item.Key} Repeats {item.Count()} times, so the total amount is {item.Sum()}");
        }

        Console.ReadKey();
    }
}