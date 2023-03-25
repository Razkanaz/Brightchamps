namespace AA;

public abstract class animal
{
    public string Name;

    public void NameOfAnimal ()
    {
        Console.WriteLine($"Hi, My name is {Name}");
    }

    abstract public void SoundOfAnimal();
}

public class cat:animal
{
    public cat()
    {
        Name = "Cat";
    }

    public override void SoundOfAnimal()
    {
        Console.WriteLine("MEOWWWW MEOOOOOOOWWWWWWWWWW MEOW MEOW MEOW MEOW");
    }
}

public class dog : animal
{
    public dog()
    {
        Name = "Dog";
    }

    public override void SoundOfAnimal()
    {
        Console.WriteLine("BARK BARK BAAARRRRRKKKK BARK");
    }
}

class AAC
{
    static void Main(string[] args)
    {
        cat Garfield = new cat();
        dog Jonathan = new dog();

        Garfield.NameOfAnimal();
        Garfield.SoundOfAnimal();

        Console.WriteLine("\n");

        Jonathan.NameOfAnimal();
        Jonathan.SoundOfAnimal();

        Console.ReadKey();
    }
}