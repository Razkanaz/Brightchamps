namespace factorial
{
    internal class Program
    {

        static int factorial (int i, int n)
        {
            if (i == 1)
            {
                return n;
            }

            return factorial(i - 1, n *= i--);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(number, 1));
        }
    }
}