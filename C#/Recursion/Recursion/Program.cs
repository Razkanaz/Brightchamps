namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;


            number = int.Parse(Console.ReadLine());

            Console.WriteLine(isprime(number, number/2));
        }

        static int isprime (int i, int enu)
        {
            if (enu == 1)
            {
                return 1;
            }

            if (i % enu != 0)
            {
                return isprime(i, enu - 1);
            }

            return 0;
        }
    }
}