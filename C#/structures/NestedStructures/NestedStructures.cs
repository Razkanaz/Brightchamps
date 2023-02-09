using Utilities;

namespace strucures;

struct DOT
{
    public int Year, month, day;
}

struct employee
{
    public string name;
    public DOT Birth;
}

class NS
{
    public static void Main(string[] args)
    {
        employee[] employees = new employee[3];

        employees[0].name = "bob";
        employees[1].name = "jim";


        employees[0].Birth.Year = 2001;
        employees[1].Birth.Year = 1997;

        employees[0].Birth.month = 3;
        employees[1].Birth.month = 2;
                    
        employees[0].Birth.day = 8;
        employees[1].Birth.day = 7;

        Console.Write("hello new employee please enter in your details\nWhat Is your Name: ");
        employees[2].name = Console.ReadLine() ?? "";

        employees[2].Birth.Year = Util.askint("What Year were you born in: ");
        employees[2].Birth.month =  Util.askint("What month were you born in: ");
        employees[2].Birth.day = Util.askint("What day were you born in: ");

        Console.WriteLine();

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Employee number {i+1}:\nName:{employees[i].name}\nDate Of Birth: {employees[i].Birth.Year}/{employees[i].Birth.month}/{employees[i].Birth.day}\n\n");
        }

        Console.ReadKey();

    }
}