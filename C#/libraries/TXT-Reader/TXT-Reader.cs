namespace TXT_reader
{
    public class Reading
    {
        string PATH = "";

        public void SetDefaultPath (string path)
        {
            PATH = path;
        }


        public void makefile()
        {
            using (FileStream file = File.Create(PATH)) { }
        }

        public void deletefile()
        {
            fileExists(PATH);

            File.Delete(PATH);
        }

        public string readfiletext()
        {
            fileExists(PATH);

            return File.ReadAllText(PATH);
        }

        public string[] readfileline()
        {
            fileExists(PATH);

            return File.ReadAllLines(PATH);
        }

        public void writefile(string data)
        {
            fileExists(PATH);

            string[] lines = data.Split(@"\n");

            using (StreamWriter writer = new StreamWriter(PATH))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        public void appendfile(string data)
        {
            fileExists(PATH);

            string[] lines = data.Split(@"\n"), old = readfileline(PATH);

            using (StreamWriter writer = new StreamWriter(PATH))
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

        //Overload
        
        public void makefile(string path)
        {
            using (FileStream file = File.Create(path)) { }
        }

        public void deletefile(string path)
        {
            fileExists(path);

            File.Delete(path);
        }

        public string readfiletext(string path)
        {
            fileExists(path);

            return File.ReadAllText(path);
        }

        public string[] readfileline(string path)
        {
            fileExists(path);

            return File.ReadAllLines(path);
        }

        public void writefile(string data, string path)
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

        public void appendfile(string data, string path)
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

        void fileExists (string path)
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
        public TXTFileNotFound(string message)
            : base(message) { }
    }
}