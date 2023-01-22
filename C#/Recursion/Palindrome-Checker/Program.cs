namespace palindrome_test
{
    internal class Program
    {

        public static bool ispalindrome (string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }

            if (text[0] == text[text.Length-1])
            {
                return ispalindrome(text.Substring(1, text.Length - 2));
            }

            return false;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(ispalindrome(str) ? "it is a palindrome":"it is NOT a palindrome");
        }
    }
}