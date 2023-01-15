using System;
using System.Text.RegularExpressions;

namespace RegexPalindrome
{
    internal class Program
    {

        

        static bool isPalindrome (string txt)
        {


            string temp = $"({txt})$";
            Regex.IsMatch(txt, @txt);

            bool x = Regex.Replace
            (

                string.Concat

                    (

                        txt.OrderBy(x => x)

                    ),

                @"([a-z])\1{1}",

                string.Empty

            ).Length <= 1;

            return x;
        }

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(isPalindrome(n));
        }
    }
}