using System;
using System.Text.RegularExpressions;

namespace HexCodeChecker
{
    class HCC
    {

        static bool HexCodeCheck (string n)
        {
            return Regex.IsMatch(n, @"[#][0-9 A-f a-f]{6}\b");
        }

        static void Main (string[] args)
        {
            string hexcode = Console.ReadLine();
            Console.WriteLine(HexCodeCheck(hexcode));
        }
    }
}