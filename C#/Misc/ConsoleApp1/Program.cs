namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[5, 5], matrix2 = new int[5,5], matrix3 = new int[5,5];
            int x, y, i = 1, add = 0;
            string print;

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    matrix1[x, y] = i;
                    matrix2[x, y] = i;
                    i++;
                }
            }

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    matrix3[x, y] = matrix1[x,y] + matrix2[x,y];
                }
            }

            Console.WriteLine("this is matrix 1:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix1[x, y]).PadRight(3 - Convert.ToString(matrix1[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 2:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix2[x, y]).PadRight(3 - Convert.ToString(matrix2[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 3:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix3[x,y]).PadRight(3 - Convert.ToString(matrix3[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }
            i = 0;

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    matrix1[x, y] = i * 3;
                    matrix2[x, y] = i;
                    i++;
                }
            }

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    matrix3[x, y] = matrix1[x, y] - matrix2[x, y];
                }
            }

            Console.WriteLine("\nthis is matrix 1:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix1[x, y]).PadRight(3 - Convert.ToString(matrix1[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 2:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix2[x, y]).PadRight(3 - Convert.ToString(matrix2[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 3:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix3[x, y]).PadRight(3 - Convert.ToString(matrix3[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            i = 1;

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    matrix1[x, y] = i;
                    matrix2[x, y] = i;
                    i++;
                }
            }



            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    add = 0;
                    for (i = 0; i < 5; i++)
                    {
                        add += matrix1[x, i] * matrix2[i, y];
                    }
                    matrix3[x, y] = add; 
                }
            }

            Console.WriteLine("\nthis is matrix 1:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix1[x, y]).PadRight(3 - Convert.ToString(matrix1[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 2:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{Convert.ToString(matrix2[x, y]).PadRight(3 - Convert.ToString(matrix2[x, y]).Length, ' ')} ";
                }
                Console.WriteLine(print);
            }

            Console.WriteLine("\nthis is matrix 3:");
            for (x = 0; x < 5; x++)
            {
                print = "";
                for (y = 0; y < 5; y++)
                {
                    print = $"{print}{matrix3[x,y]} ";
                }
                Console.WriteLine(print);
            }

            Console.ReadKey();

        }
    }
}