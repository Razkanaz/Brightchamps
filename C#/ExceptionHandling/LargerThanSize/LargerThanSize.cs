namespace Exception;

using System.Diagnostics;
using Utilities;

class Program
{
    static void Main(string[] args)
    {
        string Answers = Util.askstr("Please put in 5 numbers that are greater or eqaul to 1, seperated with spaces: ");
        string[] Numbs = Answers.Split(' ');
        int[] Numbers = new int[5];

        for (int i = 0; i < Numbs.Length; i++)
        {
            if (int.Parse(Numbs[i]) < 1)
            {
                Console.WriteLine("IT CAN'T BE LOWER THAN ONE");
                Console.ReadKey();
                return;
            }

            try
            {
                Numbers[i] = int.Parse(Numbs[i]);
            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("THAT'S TOO MANY NUMBERS");
                Console.ReadKey();
                return;
            } catch(FormatException)
            {
                Console.WriteLine("THAT'S NOT A NUMBER");
                Console.ReadKey();
                return;
            }
            
        }


        Console.WriteLine("\n\nYour numbers are:");
        foreach (int item in Numbers)
        {
            bool Prime = true;


            for (int i = 2; i < item; i++)
            {
                if (item % i == 0)
                {
                    Prime = false;
                }
            }

            switch (item)
            {
                case 0:
                    Prime = false;
                    break;

                case 1:
                    Prime = false;
                    break;

                case 2:
                    Prime = true;
                    break;

            }

            Console.WriteLine($"{item} {(Prime ? "Which is a prime number":"Which is not a prime number")}");

            
        }
        
        Console.ReadKey();
    }
}