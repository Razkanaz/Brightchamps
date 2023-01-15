using System;

class program
{
    public static void Main(string[] args)
    {
        int age, height;

        age = askint("Hold on there kiddo, you've gotta be at least 13 years old to get on this ride \nhow old are you: ");

        if (age <= 11)
        {
            Console.WriteLine("sorry kid, you're not old enough to ride");
            Console.ReadKey();
            return;
        }

        if (age == 12)
        {
            height = askint("hmmm technically you're not old enough, but i'll give you a pass, as long as you're tall enough \n what's your height (in cm): ");
        }
        else if (age <= 17)
        {
            height = askint("alright, how tall are you (in cm): ");
        }
        else
        {
            Console.WriteLine("come on in sir");
            Console.ReadKey();
            return;
        }

        if (height >= 160)
        {
            Console.WriteLine("come one in");
        }
        else
        {
            Console.WriteLine("sorry kid, you're not tall enough to ride");
        }
        Console.ReadKey();
    }

    public static int askint(string text)
    {
        Console.Write(text);
        string v = Console.ReadLine();
        while (int.TryParse(v, out _) == false)
        {
            Console.WriteLine("");
            Console.WriteLine("please enter a number");
            Console.Write(text);
            v = Console.ReadLine();
        }
        return Convert.ToInt32(v);
    }

}