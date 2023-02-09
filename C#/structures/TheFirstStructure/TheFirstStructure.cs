namespace Structure;

struct GameObject
{
    public string type;
    public static int x= 60, y = 9;
} 
    
class Game
{
    public static void Main(string[] args)
    {
        GameObject enemy = new GameObject();
        enemy.type = "ally";

        Console.WriteLine($"the current {enemy.type} location is {GameObject.x}, {GameObject.y}");
        Console.ReadKey();

    }
}