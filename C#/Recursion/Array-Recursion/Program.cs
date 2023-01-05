namespace array_recursion
{
    internal class Program
    {
        

        static int[] EOD (int[] n, bool even)
        {
            if (n.Length == 1)
            {
                if (!(n[0] % 2 == 0 ^ even))
                {
                    return new int[] {n[0]};
                } else
                {
                    return new int[] { };
                }
            }

            List<int> i = n.ToList();
            i.RemoveAt(n.Length - 1);
            int[] b = EOD(i.ToArray(), even);

            i = b.ToList();

            if (!(n[n.Length-1] % 2 == 0 ^ even))
            {
                i.Add(n[n.Length-1]);
            }

            return i.ToArray();
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            array = EOD(array, false);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}