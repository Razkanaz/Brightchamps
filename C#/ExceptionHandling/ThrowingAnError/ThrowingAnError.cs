namespace Throwing;


class Throwing
{
    static void Main(string[] args)
    {
        try
        {
            throw new DivideByZeroException("OHNO AN ERROR");
        }
        catch (DivideByZeroException a)
        {
            Console.WriteLine("AN error");
        }

        Console.WriteLine("no more error");

        Console.ReadKey();
    }
}