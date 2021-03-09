using System;
                        //Sorry to send tasks too late :(
                        //I won't be anymore to miss deadline  
namespace all_tasks_1 {

    class MainClass {

        public static void one() { //RECTANGLE
            int a, b;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            if ((a <= 0) || (b <= 0)) {
                Console.WriteLine("Incorrect input");
            }
            else {
                Console.WriteLine(a * b);
            }
        }

        public static void two() { //TRIANGLE
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                for (int j = 0; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void three() { //ANOTHER TRIANGLE
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                for (int k = 0; k < n - i - 1; k++) {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) {
                    Console.Write("*");
                }
                for (int k = 0; k < n - i - 1; k++) {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void four() { //X-MAS TREE
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int t = 1; t < n + 1; t++) {
                for (int i = 0; i < t; i++) {
                    for (int k = 0; k < n - i - 1; k++) {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * i + 1; j++) {
                        Console.Write("*");
                    }
                    for (int k = 0; k < n - i - 1; k++) {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void five() { //SUM OF NUMBERS
            int n = 1000, sum = 0;
            for (int i = 3; i < n; i++) {
                if ((i % 3 == 0) || (i % 5 == 0)) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        //public static void six() { //FONT ADJUSTMENT
        //    string s;
            
        //    Console.WriteLine("Enter the sentence:");
        //    s = Console.ReadLine();
        //    Console.WriteLine("Enter the sentence:");
        //    switch (Console.ReadLine()) {
        //        case "bold":
        //            Console.WriteLine();
        //            break;
        //        case "italic":

        //            break;
        //        case "underline":

        //            break;
        //        default:
        //            break;
        //    }
        //}

        public static void seven() { //ARRAY PROCESSING
            int n, p, max = Int32.MinValue, min = Int32.MaxValue;
            Random val = new Random();
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = val.Next(-10, 10);
                Console.Write($"{a[i]} ");
            }

            for (int i = 0; i < n; i++) {
                if (a[i] > max) {
                    max = a[i];
                }
                if (a[i] < min) {
                    min = a[i];
                }
            }

            for (int i = 0; i < n - 1; i++) { //сортировка пузырьком
                for (int j = n - 1; j > i; j--) {
                    if (a[j - 1] > a[j]) {
                        p = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = p;
                    }
                }
            }

            Console.WriteLine($"\nmax = {max}");
            Console.WriteLine($"min = {min}");
            for (int i = 0; i < n; i++) {
                Console.Write($"{a[i]} ");
            }


        }

        public static void eight() { //NO POSITIVE
            int n, m, v;
            Random val = new Random();
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("v = ");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,,] a = new int[n, m, v];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    for (int k = 0; k < v; k++) {
                        a[i, j, k] = val.Next(-10, 10);
                        Console.Write($"{a[i, j, k]} ");
                        if (a[i, j, k] > 0) {
                            a[i, j, k] = 0;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("No positive array: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    for (int k = 0; k < v; k++) {
                        Console.Write($"{a[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        public static void nine() { //NON-NEGATINE SUM
            int n, sum = 0;
            Random val = new Random();
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = val.Next(-10, 10);
                Console.Write($"{a[i]} ");
                if (a[i] >= 0) {
                    sum += a[i];
                }
            }
            Console.WriteLine($"\nSum of non-negative elements = {sum}");
        }

        public static void ten() { //2D ARRAY
            int n, m, sum = 0;
            Random val = new Random();
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, m];
            Console.WriteLine("\nArray nxm:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    a[i, j] = val.Next(1, 10);
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
 
            Console.WriteLine("\nArray nxm with only even elements:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if ((i + j) % 2 == 0) {
                        Console.Write($"{a[i, j]} ");
                        sum += a[i, j];
                    }
                    else {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nSum of even elements: {sum}");
        }


        public static void Main(string[] args) {
            Console.Write("Enter the number of task: ");
            switch (Convert.ToInt32(Console.ReadLine())) {
                case 1: {
                        one();
                        break;
                    }
                case 2: {
                        two();
                        break;
                    }
                case 3: {
                        three();
                        break;
                    }
                case 4: {
                        four();
                        break;
                    }
                case 5: {
                        five();
                        break;
                    }
                //case 6: {
                //        six();
                //        break;
                //    }
                case 7: {
                        seven();
                        break;
                    }
                case 8: {
                        eight();
                        break;
                    }
                case 9: {
                        nine();
                        break;
                    }
                case 10: {
                        ten();
                        break;
                    }

                default: Console.WriteLine("Incorrect input");
                    break;

            }
        }
    }
}
