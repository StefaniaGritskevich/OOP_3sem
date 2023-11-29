using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace lab15
{
    class TPL1
    {
       
        public static void Task1(int N)
        {
            Stopwatch stop = new Stopwatch();
            Console.WriteLine("\n------- Task 1 --------\n");
            stop.Start();
            Task task1 = new(() => FindSimpleNum(N, stop));
            Console.WriteLine($"Статус до запуска - {task1.Status}\n");
            task1.Start();
            task1.Wait();
            Console.WriteLine($"Статус после запуска - {task1.Status}\n");


        }
        public static void Task2(int N)
        {
            Console.WriteLine("----------- Task 2-----------");
            CancellationTokenSource cts = new();
            var token = cts.Token;
            Task task2 = new(() => FindSimpleNums(N, ref token), token);
            Console.WriteLine($"Статус до запуска - {task2.Status}\n");
            task2.Start();
            Console.WriteLine($"Статус после запуска - {task2.Status}\n");
            cts.Cancel();
            Thread.Sleep(2000);
        }
      

    private static List<int> FindSimpleNum(int N, Stopwatch stop = null)
        {
            List<int> simpleNums = new();

            for (int i = 2; i < N; i++)
            {
                bool isSimple = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }

                if (isSimple)
                {
                    simpleNums.Add(i);
                }
            }
            // Вывод чисел
            foreach (var num in simpleNums)
            {
                Console.Write($"{num}\n");
            }

            if (stop != null)
            {
                stop.Stop();
                Console.WriteLine($"Время выполнения: {stop.Elapsed}");
            }

            Console.WriteLine("Выполнено!");

            return simpleNums;
        }

        private static List<int> FindSimpleNums(int N, ref CancellationToken token)
        {
            List<int> simpleNums = new();

            for (int i = 2; i < N; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Задача отменена");
                    return null;
                }

                bool isSimple = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }

                if (isSimple)
                {
                    simpleNums.Add(i);
                }
                // Вывод чисел
                foreach (var num in simpleNums)
                {
                    Console.Write($"{num}\n");
                }
            }

            Console.WriteLine("Выполнено!");

            return simpleNums;
        }
    }
}



