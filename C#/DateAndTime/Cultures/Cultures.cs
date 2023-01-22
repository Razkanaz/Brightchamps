namespace DAT
{
    class Culture
    {
        static void Main(String[] args)
        {
            DateTime current = DateTime.Now;
            current = current.AddDays(40);
            Console.WriteLine(current.ToString() +" | "+ current.DayOfWeek);
            Console.ReadKey();
        }
    }
}