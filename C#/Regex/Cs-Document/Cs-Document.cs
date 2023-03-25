using System;
using System.Text.RegularExpressions;
using TXT_reader;

namespace Csdoc
{
    class CD
    {
        static void Main(string[] args)
        {
            Reading Read = new Reading();

            Read.SetDefaultPath(@"C:\Users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt");

            if (!File.Exists(@"C:\Users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt"))
            {
                Read.makefile();

                Console.Write("what do you want to put in the file: ");
                Read.writefile(Console.ReadLine() ?? "");
                return;
            }

            // 1 = read -- show the file and check if it includes c#
            // 2 = Replace -- replace the text
            int mode;
            Console.Write("do you want to check if the document is a C# document or change the document?\n1 = read\n2 = replace\npick: ");
            mode = int.Parse(Console.ReadLine() ?? "");

            if (mode == 1)
            {
                string document = Read.readfiletext();

                Console.WriteLine("\n" + document);

                Console.WriteLine(Regex.IsMatch(document, Regex.Escape("C#"), RegexOptions.IgnoreCase) ? "this is a C# documents" : "This is not a C# document");
            } else
            {
                Read.makefile();

                Console.Write("what do you want to put in the file: ");
                Read.writefile(Console.ReadLine() ?? "");
                
            }
        }
    }
}