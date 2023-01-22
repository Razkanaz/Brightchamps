using System;

namespace switches
{
    class SW
    {

       
        static void Main(string[] args)
        {
            ConsoleKey mode;
            Console.Write("what mode do you want to join\nP = play\nD = delete\nM = make\nE = edit\npick: ");
            mode = Console.ReadKey().Key;
            Console.WriteLine("\n");

            switch (mode)
            {
                case ConsoleKey.P:
                    play();
                    break;

                case ConsoleKey.D:
                    delete();
                    break;

                case ConsoleKey.M:
                    make();
                    break;

                case ConsoleKey.E:
                    edit();
                    break;

                default:
                    Console.WriteLine("\nthat's not valid");
                    Main(args);
                    break;
            }
        }

        static void edit () { Console.WriteLine("you have entered edit mode"); }
        static void delete () { Console.WriteLine("you have entered delete mode"); }
        static void make () { Console.WriteLine("you have entered make mode"); }
        static void play () { Console.WriteLine("you have entered play mode"); }
    }
}