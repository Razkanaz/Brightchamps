namespace Inheritence;

class NPC
{
    public int x, y;
    public int health;

    public void getpos ()
    {
        Console.WriteLine($"X:{x}\nY:{y}");
    }
}

class Enemy : NPC
{
    public int attackdmg;

    public void getStats ()
    {
        Console.WriteLine($"Health: {health}\nAttackDMG: {attackdmg}");
    }
}

class FI
{
    static void Main(string[] args)
    {
        Enemy Barbarian = new Enemy();

        Barbarian.x = 10;
        Barbarian.y = -10;
        Barbarian.health = 100;
        Barbarian.attackdmg = 15;

        Barbarian.getpos();
        Barbarian.getStats();

        Console.ReadKey();
    }
}