namespace fibonacci
{
    internal class Program
    {

        static int fibonacci (int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            int i1 = fibonacci(n - 1);
            int i2 = fibonacci(n - 2);

            return i1 + i2;
            
        }
        

        static void Main(string[] args)
        {
            Console.Write("what is the Nth number of the fibonacci's sequence: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nthe {number}th number of the fibonacci is: " + fibonacci(number));
        }
    }
}