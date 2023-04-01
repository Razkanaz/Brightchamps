namespace Inters;

class VideoPlayer
{
    public virtual void Play()
    {
        Console.WriteLine("Play Video");
    }

    public virtual void Pause()
    {
        Console.WriteLine("Pause Video");
    }
}

interface ExtraFeatures
{
    public void FastForward();
}

class Client1 : VideoPlayer, ExtraFeatures
{
    public override void Play()
    {
        Console.WriteLine("Play Client 1");
    }

    public override void Pause()
    {
        Console.WriteLine("Pause Client 1");
    }

    void ExtraFeatures.FastForward()
    {
        Console.WriteLine("Fast Forward Client 1");
    }
}

class client2 : VideoPlayer
{
    public override void Play()
    {
        Console.WriteLine("Play Client 2");
    }

    public override void Pause()
    {
        Console.WriteLine("Pause Client 2");
    }
}

class main
{
    static void Main(string[] args)
    {
        ExtraFeatures EF = new Client1();
        Client1 C1 = new Client1();

        C1.Play();

        C1.Pause();

        EF.FastForward();

        Console.ReadKey();
    }
}