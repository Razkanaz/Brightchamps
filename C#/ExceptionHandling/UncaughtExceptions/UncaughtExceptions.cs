namespace Exception;

using Utilities;

class program
{
    static void Main(string[] args)
    {
        int x = 0, div = 12;

        x = Util.askint("Pick any number: ");

		try
		{
            div = 100 / x;
            Console.WriteLine($"100/{x} is {div}");
        }
		catch (DivideByZeroException)
		{
            Console.WriteLine("you can't divide by zero stupid");
		}
        finally
        {
            Console.WriteLine("Thank you For participating");
        }

        Console.WriteLine($"\noh btw {x} is a stupid number");

        Console.ReadKey();
    }
}