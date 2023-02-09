namespace Utilities
{
    public class Util
    {
        public static int askint(string question, string errorMessage = "please put in a valid number\n")
        {
            string answer = "";
            while (!int.TryParse(answer, out _))
            {
                Console.Write(question);
                answer = Console.ReadLine() ?? "";
                if (!int.TryParse(answer, out _))
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return int.Parse(answer);
        }

        public static string askstr(string question, string errorMessage = "please put in something\n")
        { 
            string answer = "";

            while (answer == string.Empty)
            {
                Console.Write(question);
                answer = Console.ReadLine() ?? "";
                if (answer == string.Empty)
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return answer;
        }

        public static bool keyPressed (ConsoleKeyInfo check,ConsoleKey key)
        {
            return check.Key == key;
        }

        public static void ClearConsoleLine(int line, int returnto = -50)
        {
            if (returnto == -50)
            {
                returnto = Console.CursorTop;
            }
            Console.SetCursorPosition(0, line);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, returnto);
        }
    }
}