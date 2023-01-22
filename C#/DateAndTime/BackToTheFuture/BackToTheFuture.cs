using Utilities;

namespace DAT
{
    class BTTF
    {
        static void Main(string[] args)
        {
            int year, month, day;
            year = Util.askint("please put in a year: ");
            month = Util.askint("Please put in a month: ");
            day = Util.askint("Please put in a day: ");

            DateTime pickedTime = new DateTime(year, month, day), newtime;

            for (int i = -15; i <= 15; i++)
            {
                newtime = pickedTime.AddYears(i);
                Console.WriteLine($"{newtime.ToString("dd/MM/yyyy")} {(i < 0 ? $"{Math.Abs(i)} years ago":$"{i} years later")}");
            }

            Console.ReadKey();
        }
    }
}