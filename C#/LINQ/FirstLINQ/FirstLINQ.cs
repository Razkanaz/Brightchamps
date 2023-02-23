using System.Linq;
namespace linq;

class First
{
    public static void Main(string[] args)
    {
        int[] Numbers = { 1, 2,3, 4, 5,6, 7, 8,9 , 10, 11, 12};

        var query = from Number in Numbers where Number % 2 == 0 where Number % 3 == 0 select Number;

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    } 
}