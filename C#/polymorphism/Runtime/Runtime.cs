namespace CriticOpinion;

class Program
{
    public class SongReview
    {
        public virtual void Opinion ()
        {
            Console.WriteLine("I love Tylers New Album, cherry bomb");
        }
    }

    class Fantano : SongReview
    {
        public override void Opinion ()
        {
            Console.WriteLine("I hate tylers new album");
        }
    }

    class Tyler : SongReview
    {
        public override void Opinion ()
        {
            Console.WriteLine("I loved making My new album");
        }
    }

    public static void Main(string[] args)
    {
        SongReview s = new SongReview();
        Fantano fantano = new Fantano();
        Tyler tylertylertyler = new Tyler();

        s.Opinion();
        fantano.Opinion();
        tylertylertyler.Opinion();

        Console.ReadKey();
    }

}