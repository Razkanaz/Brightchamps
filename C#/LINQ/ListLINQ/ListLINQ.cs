using System.Linq;
using Utilities;

namespace LINQ;

class LIST
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int over = Util.askint("Please put in a number: ");

        List<int> numbers = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            numbers.Add(rnd.Next(over - 100, over + 101));
        }

        Console.WriteLine("the members of the list: \n");
        foreach (var item in numbers)
        {
            Console.Write(item + ", ");
        }

        List<int> Filterlist = numbers.FindAll(x => x > over);

        Console.WriteLine("\n\nThe numbers over {0} are:", over);
        foreach (var item in Filterlist)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}