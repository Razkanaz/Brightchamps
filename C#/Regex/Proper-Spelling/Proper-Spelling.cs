using System;

namespace Spelling
{
    class PS
    {
        static void Main(string[] args)
        {
            Console.Write("write a series of names: ");
            string n = Console.ReadLine() ?? "";
            string[] naray = n.Split(" ");
            for (int i = 0; i < naray.Length; i++) { naray[i] = $"{char.ToUpper(naray[i][0])}{naray[i].Substring(1)}"; }
            Console.WriteLine(string.Join(" ", naray) == n ? "the spelling is correct":"the spelling is incorrect");
        }
    }
}