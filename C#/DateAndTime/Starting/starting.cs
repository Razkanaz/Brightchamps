using System;
using System.Security;

namespace DAT
{
    class Start
    {
        static void Main(string[] args)
        {
            DateTime Independance = new DateTime(1945, 8, 17, 5, 5, 5);
            Console.WriteLine(Independance.ToString());

            DateTime independanceDate = Independance.Date;

            Console.WriteLine(independanceDate.ToString("dd/MM/yyyy"));
        }
    }
}