namespace Inheritence;

class DefaultNPC
{
    public int x, y;

    public string Sprite;

    public void getpos()
    {
        Console.WriteLine($"X:{x}\nY:{y}");
    }
}

class NPC : DefaultNPC
{
    public string dialogue;

    public void Talk()
    {
        Console.WriteLine(dialogue);
    }
}

class Enemy : DefaultNPC
{
    public int health, defense;
}

class Wizard : Enemy
{
    public int magicdmg;
    public string name;
    public Wizard (string name, int dmgOffset = 0, int healthOffset=0, int defenseOffset=0)
    {
        this.name = name;
        Sprite = "wizard";
        health = 150 + healthOffset;
        defense = 15 + defenseOffset;
        magicdmg = 20 + dmgOffset;
    }

    
    public void GetStats ()
    {
        Console.WriteLine($"{name}'s Stats:\nHealth: {health}\nDefense: {defense}\nMagicDMG: {magicdmg}\n\n");
    }
}

class NPCI
{
    static void Main(string[] args)
    {
        Wizard Magius = new Wizard("Magius");

        Magius.GetStats();

        NPC Magicus = new NPC ();

        Magicus.dialogue = "why hello there youngling, do you need help?";

        Magicus.Talk();

        Console.ReadKey();
    }
}