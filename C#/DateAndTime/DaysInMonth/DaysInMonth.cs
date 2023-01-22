using Utilities;

namespace DAT
{
    class BTTF
    {
        static void Main(string[] args)
        {
            int year, month;
            year = Util.askint("please put in a year: ");
            month = Util.askint("Please put in a month: ");

            Console.WriteLine($"There are {DateTime.DaysInMonth(year, month)} days in that month");
            Console.ReadKey();
        }
    }
}