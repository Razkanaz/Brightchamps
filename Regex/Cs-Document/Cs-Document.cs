using System;
using System.Text.RegularExpressions;
using TXT_reader;

namespace Csdoc
{
    class CD
    {
        static void Main(string[] args)
        {
            
            if (!File.Exists(@"C:\Users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt"))
            {
                Writefile();
                return;
            }

            // 1 = read -- show the file and check if it includes c#
            // 2 = Replace -- replace the text
            int mode;
            Console.Write("do you want to check if the document is a C# document or change the document?\n1 = read\n2 = replace\npick: ");
            mode = int.Parse(Console.ReadLine() ?? "");

            if (mode == 1)
            {
                readfile();
            } else
            {
                Writefile();
            }
           
            

        }

        static void Writefile ()
        {
            Reading.makefile(@"C:\Users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt");

            Console.Write("what do you want to put in the file: ");
            Reading.writefile(Console.ReadLine()?? "", @"C:\Users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt");
        }

        static void readfile ()
        {
            string document = Reading.readfiletext(@"C:\users\aznee\Documents\Real_documents\coding\C#\Brightchamps\Regex\Cs-Document\Document.txt");

            Console.WriteLine("\n" + document);

            Console.WriteLine(Regex.IsMatch(document, Regex.Escape("C#"), RegexOptions.IgnoreCase) ? "this is a C# documents":"This is not a C# document");
        }
    }
}