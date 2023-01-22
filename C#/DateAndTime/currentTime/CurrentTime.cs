namespace DAT
{
    class CT
    {
        static void Main(string[] args)
        {
            DateTime CurrentDate = DateTime.Now;

            while (true)
            {
                CurrentDate = DateTime.Now;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.Write($"Year = {CurrentDate.Year}\nMonth = {CurrentDate.Month}\nDay = {CurrentDate.Day}\nDay Of The Week = {CurrentDate.DayOfWeek}\nHour = {CurrentDate.Hour}\nMinutes = {CurrentDate.Minute}\nSeconds = {CurrentDate.Second}");
                Thread.Sleep(1000);
            }
        }
    }
}
