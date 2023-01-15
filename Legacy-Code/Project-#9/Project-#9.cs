using System;

class program
{
    public static void Main(string[] args)
    {

        Console.Write("write a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { " " }, StringSplitOptions.None);

        if (words.Length < 2)
        {
            Console.WriteLine("you must enter more than 1 word");
            Console.ReadKey();
            return;
        }

        int letterlenght = 0;
        string output = "";
        foreach (string sets in words)
        {
            if (sets.Length > letterlenght)
            {
                letterlenght = sets.Length;
                output = sets;
            }
        }

        Console.WriteLine($"the longest word in that sentence is {output}");
        Console.ReadKey();
    }
}