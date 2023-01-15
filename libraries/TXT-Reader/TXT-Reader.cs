namespace TXT_reader
{
    public class Reading
    {
        public static void makefile(string path)
        {
            using (FileStream file = File.Create(path)) { }
        }

        public static void deletefile(string path)
        {
            fileExists(path);

            File.Delete(path);
        }

        public static string readfiletext(string path)
        {
            fileExists(path);

            return File.ReadAllText(path);
        }

        public static string[] readfileline(string path)
        {
            fileExists(path);

            return File.ReadAllLines(path);
        }

        public static void writefile(string data, string path)
        {
            fileExists(path);

            string[] lines = data.Split(@"\n");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        public static void appendfile(string data, string path)
        {
            fileExists(path);

            string[] lines = data.Split(@"\n"), old = readfileline(path);

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string p in old)
                {
                    writer.WriteLine(p);
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        static void fileExists (string path)
        {
            if (!File.Exists(path))
            {
                throw new TXTFileNotFound("File not found");
            }
        }
        
    }

    [Serializable]
    public class TXTFileNotFound : Exception
    {
        public string StudentName { get; }

        public TXTFileNotFound() { }

        public TXTFileNotFound(string message)
            : base(message) { }

        public TXTFileNotFound(string message, Exception inner)
            : base(message, inner) { }

        public TXTFileNotFound(string message, string studentName)
            : this(message)
        {
            StudentName = studentName;
        }
    }
}