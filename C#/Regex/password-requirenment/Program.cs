using System.Text.RegularExpressions;

namespace password_requirenment
{
    internal class Program
    {
        static bool[] passwordcheck (string password)
        {
            bool[] temp = new bool[4];

            temp[0] = password.Length < 8;
            temp[1] = password == password.ToLower();
            temp[2] = !Regex.IsMatch(password, @"(#|\$|\@|\&|\*|\%)");
            temp[3] = !Regex.IsMatch(password, @"([0-3]|[3-9])");

            return temp;
        }

        static void Main(string[] args)
        {
            Console.Write("input password:");
            string n = Console.ReadLine() ?? "";
            bool[] check = passwordcheck(n);

            Console.WriteLine(check[0] ? "must be longer than 8 characters": "✓ passes check 1 (longer than 8 characters)");
            Console.WriteLine(check[1] ? "does not contain atleast 1 uppercase character": "✓ passes check 2 (contains uppercase)");
            Console.WriteLine(check[2] ? "does not contain atleast 1 special symbol": "✓ passes check 3 (contains special symbol)");
            Console.WriteLine(check[3] ? "does not contain atleast 1 number": "✓ passes check 4 (contains number)");
        }
    }
}