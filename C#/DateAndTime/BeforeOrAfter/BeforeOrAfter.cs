using Utilities;

namespace DAT
{
    class BTTF
    {
        static void Main(string[] args)
        {
            int year, month, day;
            int year2, month2, day2;
            year = Util.askint("please put in a year: ");
            month = Util.askint("Please put in a month: ");
            day = Util.askint("Please put in a day: ");
            year2 = Util.askint("please put in another year: ");
            month2 = Util.askint("Please put in another month: ");
            day2 = Util.askint("Please put in another day: ");

            DateTime time1 = new DateTime(year, month, day), time2 = new DateTime(year2, month2, day2);
            
            Console.WriteLine(DateTime.Compare(time1, time2) == 1 ? $"{time1.ToString("dd/MM/yyyy")} is later than {time2.ToString("dd/MM/yyyy")}" : $"{time2.ToString("dd/MM/yyyy")} is later than {time1.ToString("dd/MM/yyyy")}");
            Console.ReadKey();
        }
    }
}