using System;

class program
{
    public static void Main(string[] args)
    {

        while (true)
        {
            string input = (Console.ReadLine()).ToUpper();
            string output = "";
            string temp;
            for (int i = 0; i < input.Length; i++)
            {
                temp = Convert.ToString(input[i]);
                if (temp == " ")
                {
                    output = $"{output}:blank:";
                }
                else if (temp == "?")
                {
                    output = $"{output}:QuestionMark:";
                }
                else
                {
                    output = $"{output}:{temp}{temp}:";
                }
            }

            Console.WriteLine(output);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}