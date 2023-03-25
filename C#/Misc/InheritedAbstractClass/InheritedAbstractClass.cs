using Utilities;
namespace IAC;

class IAC
{
    abstract class Vehicle
    {
        public abstract float Distance { get; set; }
        public abstract float Time { get; set; }

        public abstract void speed();

    }

    class Car:Vehicle
    {
        float MDistance, MTime;
        public override float Distance 
        {
            get
            {
                return MDistance;
            } 
            set
            {
                MDistance = Math.Max(1, value);
            } 
        }

        public override float Time
        {
            get
            {
                return MTime;
            }
            set
            {
                MTime = Math.Max(1, value);
            }
        }

        public override void speed()
        {
            Console.WriteLine($"The Car Is going {MDistance/MTime}M/S");
        }
    }

    static void Main(string[] args)
    {
        Car HondaCivic = new Car();
        HondaCivic.Distance = Util.askfloat("How Far Did the car go: ");
        HondaCivic.Time = Util.askfloat("How long did it take to get there: ");
        HondaCivic.speed();

        Console.ReadKey();
    }
}