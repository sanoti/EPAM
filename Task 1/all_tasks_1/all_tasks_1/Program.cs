using System;
using System.Collections.Generic;

namespace all_tasks_1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of task: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        One();
                        break;
                    }
                case "2":
                    {
                        Two();
                        break;
                    }
                case "3":
                    {
                        Three();
                        break;
                    }
                case "4":
                    {
                        Four();
                        break;
                    }
                case "5":
                    {
                        Five();
                        break;
                    }
                case "6":
                    {
                        Six();
                        break;
                    }
                case "7":
                    {
                        Seven();
                        break;
                    }
                case "8":
                    {
                        Eight();
                        break;
                    }
                case "9":
                    {
                        Nine();
                        break;
                    }
                case "10":
                    {
                        Ten();
                        break;
                    }

                default:
                    Console.WriteLine("Incorrect input");
                    break;

            }
        }

        public static void One()
        { //RECTANGLE
            Console.Write("a = ");
            if (!int.TryParse(Console.ReadLine(), out int a) || a < 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.Write("b = ");
            if (!int.TryParse(Console.ReadLine(), out int b) || b < 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.WriteLine(a * b);
        }

        public static void Two()
        { //TRIANGLE
            Console.Write("triangle size = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string star = "*";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void Three()
        { //ANOTHER TRIANGLE
            Console.Write("triangle size = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string star = "*", space = " ";
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write(space);
                }
                for (int j = -1; j < 2 * i; j++)
                {
                    Console.Write(star);
                }
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write(space);
                }
                Console.WriteLine();
            }
        }

        public static void Four()
        { //X-MAS TREE
            Console.Write("n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            string star = "*", space = " ";
            for (int t = 1; t < n + 1; t++)
            {
                for (int i = 0; i < t; i++)
                {
                    for (int k = 0; k <= n - i; k++)
                    {
                        Console.Write(space);
                    }
                    for (int j = -1; j < 2 * i; j++)
                    {
                        Console.Write(star);
                    }
                    for (int k = 0; k <= n - i; k++)
                    {
                        Console.Write(space);
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Five()
        { //SUM OF NUMBERS
            // 1 + 2 + ... + n = n * (n + 1) / 2

            // кол-во чисел кратных x до 1000 = 999/x

            // сумма кратных трем до 1000:
            // 3 + 6 + 9 + ... + 999 = 3 * (1 + 2 + 3 + ... + 333) = 


            Console.WriteLine((3 * (999 / 3 * (999 / 3 + 1)) / 2) +
                              (5 * (999 / 5 * (999 / 5 + 1)) / 2) -
                              (15 * (999 / 15 * (999 / 15 + 1)) / 2));
        }


        [Flags]
        enum Mark
        {
            //None = 0b_000_0000, // 11
            //Bold = 0b_000_0011, // 3
            //Italic = 0b_000_0101, // 5
            //Underline = 0b_000_0111 // 7
            None,
            Bold = 1,
            Italic = 10,
            Underline = 100


        }
        public static void Six()
        { //FONT ADJUSTMENT
            Mark mark = Mark.None;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Your marks: {mark}");
                Console.WriteLine($"Choose mark");
                Console.WriteLine($"1 - {(Mark)1}");
                Console.WriteLine($"2 - {(Mark)10}");
                Console.WriteLine($"3 - {(Mark)100}");

                Console.WriteLine("Enter the mark:");
                if (!int.TryParse(Console.ReadLine(), out int Enter) || Enter < 0)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                switch (Enter)
                {
                    case 1:
                        if ((int)mark % 10 == 1)
                            mark -= 1;
                        else
                            mark += 1;

                        break;
                    case 2:
                        if ((int)mark / 10 % 10 == 1)
                            mark -= 10;
                        else
                            mark += 10;

                        break;
                    case 3:
                        if ((int)mark / 100 == 1)
                            mark -= 100;
                        else
                            mark += 100;

                        break;
                    default:
                        break;
                }
            }
        }


        public static void Seven()
        { //ARRAY PROCESSING
            Random val = new Random();
            Console.Write("n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = val.Next(-10, 10);
                Console.Write($"{a[i]} ");
            }

            int p, max = a[0], min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            
            for (int i = 0; i < n - 1; i++)
            { //сортировка пузырьком
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        p = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = p;
                    }
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }


        }

        public static void Eight()
        { //NO POSITIVE
            Random val = new Random();
            Console.Write("first dimension of array = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.Write("second dimention of array = ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.Write("third dimention of array = ");
            if (!int.TryParse(Console.ReadLine(), out int v) || v <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.WriteLine();

            int[,,] a = new int[n, m, v];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < v; k++)
                    {
                        a[i, j, k] = val.Next(-10, 10);
                        Console.Write($"{a[i, j, k]} ");
                        if (a[i, j, k] > 0)
                        {
                            a[i, j, k] = 0;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("No positive array: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < v; k++)
                    {
                        Console.Write($"{a[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        public static void Nine()
        { //NON-NEGATINE SUM
            int sum = 0;
            Random val = new Random();
            Console.Write("n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = val.Next(-10, 10);
                Console.Write($"{a[i]} ");
                if (a[i] >= 0)
                {
                    sum += a[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of non-negative elements = {sum}");
        }

        public static void Ten()
        { //2D ARRAY
            int sum = 0;
            Random val = new Random();
            Console.Write("first dimension of array = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Console.Write("second dimention of array = ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[,] a = new int[n, m];
            Console.WriteLine("\nArray nxm:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = val.Next(1, 10);
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Array nxm with only even elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write($"{a[i, j]} ");
                        sum += a[i, j];
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of even elements: {sum}");
        }
    }
}
