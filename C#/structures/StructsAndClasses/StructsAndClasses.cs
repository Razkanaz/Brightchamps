namespace structures;

struct Template
{
    public int x, y;
}

class Temp
{
    public int x, y;
}

class StructClass
{
    public static void Main(string[] args)
    {
        Template struct1 = new Template();
        struct1.y = 0;
        struct1.x = 0;
        Template struct2 = struct1;
        struct1.x = 10;
        struct1.y = 20;

        Temp class1 = new Temp();
        class1.y = 0;
        class1.x = 0;
        Temp class2 = class1;
        class2.x = 10;
        class2.y = 20;

        Console.WriteLine($"structure 1: X = {struct1.x} Y = {struct1.y}");
        Console.WriteLine($"structure 2: X = {struct2.x} Y = {struct2.y}");
        Console.WriteLine($"class 1: X = {class1.x} Y = {class1.y}");
        Console.WriteLine($"class 2: X = {class2.x} Y = {class2.y}");
        Console.ReadKey();

    }
}