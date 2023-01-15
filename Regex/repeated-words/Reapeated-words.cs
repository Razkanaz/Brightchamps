using System;
using System.Text.RegularExpressions;

namespace repeatedwords
{
    class RW
    {
        static void Main (string[] args)
        {
            string test = "this this is is a test test";
            string[] usedWords = new string[test.Length], words = test.Split(" ");
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (usedWords.Contains(words[i]))
                {
                    count += (Regex.Count(test, words[i]) > 1) ? 0:1;
                    usedWords[i] = words[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}