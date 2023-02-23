using System.Linq;

namespace LINQ;

class LET
{
    static void Main(string[] args)
    {
        int[] Ns = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, };

        var Sqr = from int number in Ns let SQR = number * number where SQR > 250 where SQR % 2 == 0 select new {number, SQR};

        foreach (var s in Sqr)
        {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}