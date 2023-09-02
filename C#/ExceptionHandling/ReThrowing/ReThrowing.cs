namespace ReThrow;

public class Division
{
    public int x, y;
}

public class DivideZero : Division
{
    public void Divide ()
    {
        try
        {
            x = 100;
            y = 0;

            Console.WriteLine(x / y);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't Divide By zero");
            throw;
        }

        
    }
}

class Rethrow
{
    static void Main(string[] args)
    {
        try
        {
            DivideZero o = new DivideZero();

            o.Divide();
        } 
        catch (Exception)
        {
            Console.WriteLine("error in section 1");
        }

        Console.ReadKey();
    }
}
