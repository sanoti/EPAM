using System;
using System.Collections;
using System.Collections.Generic;

namespace task_3
{
    //class MainClass //WEAKEST LINK
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<int> Krug = new List<int>();

    //        Console.Write("N = ");
    //        if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
    //        {
    //            Console.WriteLine("Incorrect input");
    //            return;
    //        }

    //        //Console.Write("Enter the number of people to be removed in each round: ");
    //        //if (!int.TryParse(Console.ReadLine(), out int Jumping) || Jumping < 2)
    //        //{
    //        //    Console.WriteLine("Incorrect input");
    //        //    return;
    //        //}

    //        for (int i = 0; i < N; i++)
    //        {
    //            Krug.Add(i + 1);
    //        }

    //        Console.WriteLine("Circle of people is generated. We start deleting every second");

    //        for (int i = 0, j = 0; N > 1; i++, N--)
    //        {
    //            Console.WriteLine($"Turn {++j}. Person is deleted. People left: {N - 1}");

    //            if (i >= N)
    //            {
    //                i = 0;
    //            }
    //            Krug.RemoveAt((i + 1) % N);
    //            //if (Jumping > N)
    //            //    break;
    //        }

    //        Console.WriteLine("Game over. It is impossible to deleting more people");
    //    }
    //}

    class MainClass //TEXT ANALYSIS
    {
        public static void Main(string[] args)
        {
            string Input;
            Console.WriteLine("Enter the sentece:");
            Input = Console.ReadLine();

            string[] StrMas = Input.ToLower().Split(new[] { ' ', '!', '?', ':', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] Count = new int[StrMas.Length];

            for (int i = 0; i < StrMas.Length; i++)
            {
                while (StrMas[i] == "!" && i < StrMas.Length - 1) { //пропуск повторяющихся слво
                    Count[i] = -1;
                    i++;
                }
                for (int j = i + 1; j < StrMas.Length; j++)
                {
                    if (StrMas[i] == StrMas[j])
                    {
                        Count[i]++;
                        StrMas[j] = "!"; //"удаление" слов, которые уже были
                    }
                }
            }

            //for (int i = 0; i < Count.Length; i++) //вывод счетчиков
            //{
            //    Console.Write(Count[i] + " ");
            //}

            int Max1 = 0, Max2 = 1;
            for (int i = 1; i < Count.Length; i++) //максимальный счетчик
            {
                if (Count[i] > Count[Max1])
                {
                    Max1 = i;
                }
                   
            }
            for (int i = 2; i < Count.Length; i++) //предмакчимальный счетчик
            {
                if (Count[i] > Count[Max2] && Count[i] != Count[Max1])
                {
                    Max2 = i;
                }
                    
            }
            Console.WriteLine();
            Console.WriteLine(Max1 + " " + Max2);

            Console.WriteLine("The most popular words:");
            Console.WriteLine($"{StrMas[Max1]} - {Count[Max1] + 1} times");
            Console.WriteLine($"{StrMas[Max2]} - {Count[Max2] + 1} times");


            //List<int> K = new List<int>() { 1, 4, 5, 1, 2, 1, 9 };

            //K.Remove(1);

            //foreach(int i in K)
            //{
            //    Console.WriteLine(i);
            //}

            //K.Remove(1);
            //Console.WriteLine();
            //foreach (int i in K)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }





}
