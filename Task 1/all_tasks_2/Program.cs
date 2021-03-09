using System;
using System.Linq;
using System.Globalization;

namespace all_tasks_2 {

    class MainClass {
        public static void one() { // AVERAGES
            string input;           //вариант подсчета средней длины с дробным результатом
            double val = 0;
            int c = 0;
            Console.WriteLine("Enter the sentece:");
            input = Console.ReadLine();

            string[] S_mas = input.Split(new[] { ' ', '!', '?', ':', ',', '.', ';'});
            foreach (string i in S_mas) {
                val += i.Length;
                c++;
            }
            Console.WriteLine(val / c);
        }

        public static void two() { // DOUBLER
            string input, changes, result = "";
            Console.WriteLine("Enter the sentece:");
            input = Console.ReadLine();
            Console.WriteLine("Enter the word, that will be change the srntence:");
            changes = Console.ReadLine();

            foreach (char i in input) {
                if (changes.Contains(i)) {
                    result += i;
                    result += i;
                }
                else {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }

        public static void three() { // LOWERCASE
            string input, check = "абвгдежзиийклмнопрстуфхцчшщъыьэюя";
            int c = 0;
            Console.WriteLine("Enter the sentece:");
            input = Console.ReadLine();

            string[] S_mas = input.Split(new[] { ' ', '!', '?', ':', ',', '.', ';'});
            foreach (string i in S_mas) {
                if (check.Contains(i[0]))
                    c++;
            }
            Console.WriteLine(c);
        }

        public static void four() { // VALIDATOR
            //string input, result = "", check = "абвгдежзиийклмнопрстуфхцчшщъыьэюя";
            //Console.WriteLine("Enter the sentece:");
            //input = Console.ReadLine();
            //char p = input[0];
            //result += Convert.ToChar(p + 20);
            //Console.WriteLine(result);
            //for (int i = 0; i < input.Length; i++) {

            //    result +=
            //}

            //string[] S_mas = input.Split(new[] { '.', '?', '!' });
            //foreach (string i in S_mas) {
            //    if (check.Contains(i[0]) || i.StartsWith(" ")) //((i[0] == ' ') && check.Contains(i[1])))
            //        i[0] += 20;
            //    Console.WriteLine(i);

            //    Console.WriteLine(i.T);
            //}

        }

        public static void Main(string[] args) {
            Console.Write("Enter the number of task: ");
            switch (Console.ReadLine()) {
                case "1":
                    one();
                    break;
                case "2":
                    two();
                    break;
                case "3":
                    three();
                    break;
                case "4":
                    four();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;

            }
        }
    }
}
