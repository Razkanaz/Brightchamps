using System.Linq;
using Utilities;

namespace LINQ;

class SE
{
    static void Main(string[] args)
    {
        string[] countries = {"Rome", "Italy", "Indonesia", "America", "Turkey", "Japan", "Germany", "india", "Russia", "Astonia" };

        char CHS = Util.askchar("Put in The Starting character:"), CHE = Util.askchar("please put in the last character:");

        var country = from count in countries where count.StartsWith(CHS) where count.EndsWith(CHE) select count;

        foreach (var item in  country)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}