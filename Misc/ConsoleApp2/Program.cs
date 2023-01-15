using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] decimals = {decimal.MaxValue, 15.55m, 0, 17.23m, decimal.MinValue};
            foreach  (decimal value in decimals)
            {
                Console.WriteLine($"the absolute of {value} = {Math.Abs(value)}");
            }
            Console.WriteLine("\n");
            double[] doubles = {double.MaxValue, 23.6, 0, -42.69, double.MinValue};
            foreach (double value in doubles)
            {
                Console.WriteLine($"the absolute of {value} = {Math.Abs(value)}");
            }
            Console.WriteLine("\n");
        }
    }
}