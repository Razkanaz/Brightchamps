using System.Globalization;
using Utilities;

namespace DAT
{
    class Age
    {
        static void Main(string[] args)
        {
            string UtilIntError = "please put in a number\n";

            int year = 0, month= 999;

            while (year.ToString().Length < 4 || year.ToString().Length > 4)
            {
                year = Util.askint("what Year were you born in: ", UtilIntError);
                if (year.ToString().Length < 4 || year.ToString().Length > 4)
                {
                    Console.WriteLine("please put in a real year\n");
                }
            }
            Console.WriteLine();
            while (month > 12)
            {
                month = Util.askint("which month were you born in: ", UtilIntError);
                if (month > 12)
                {
                    Console.WriteLine("please put in a real months\n");
                }
            }
            DateTime currentTime = DateTime.Now;

            int YearAge, MonthAge;
            YearAge = currentTime.Year - year;
            MonthAge = currentTime.Month - month;

            if (MonthAge < 0)
            {
                YearAge--;
                MonthAge = (12 - month) + currentTime.Month;
            }

            Console.WriteLine($"you are {YearAge} years {(MonthAge == 0 ? "":$"{MonthAge} months ")}old");
            Console.ReadKey();
        }
    }
}