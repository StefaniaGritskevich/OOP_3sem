using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab14
{
    class Help
    {
        private static string name_file = "forlab14.txt";
        private static Mutex mutex = new();
        public static void ShowProces()
        {
            var allProcess = Process.GetProcesses();
            foreach (var process in allProcess)
            {
                try
                {
                    Console.WriteLine($"Id процесса {process.Id}\n" +
                        $"Имя процесса {process.ProcessName}\n" +
                        $"Время запуска {process.StartTime}\n" +
                        $"Текущее состояние {process.Responding}\n" +
                        $"Время работы процесса - {process.TotalProcessorTime}\n" +
                        $"Время загрузки процесса - {process.UserProcessorTime}\n");
                }
                catch (Exception e) { };

            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Количество процессов - {allProcess.Length}");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public static void ShowDomain()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            AppDomain domain = AppDomain.CurrentDomain; // текущий домен приложения
            Console.WriteLine($"Имя домена - {domain.FriendlyName}");
            Console.WriteLine("Базовый каталог:\n" + domain.BaseDirectory);
            Console.WriteLine($"Детали конфигурации - {domain.SetupInformation}");
            Console.WriteLine("Сборки, загруженные в домен:");

            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine(asm.GetName().Name);
            }
        }

/// //////////////////////////////////


        public static void ShowNumbers()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var first = new Thread(PrintSimpleNumbers);
            first.Start();
            first.Name = "Simple_numbers";
            first.Join();
            Console.WriteLine();

        }
        public static void ShowInfo(object thread)
        {
            var z = thread as Thread;
            Console.WriteLine($"Имя потока - {z.Name}\n" +
                              $"Приоритет потока - {z.Priority}\n" +
                              $"Статус потока - {z.ThreadState}\n" +
                              $"Поток фоновый - {z.IsBackground}\n" +
                              $"Поток запущен - {z.IsAlive}\n" +
                              $"Поток приостановлен - {z.IsThreadPoolThread}\n");
        }
        public static void PrintSimpleNumbers()
        {
            var first = new Thread(ShowInfo);
            first.Start(Thread.CurrentThread);
            first.Join();

            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            // Проверка на простоту
            for (int i = 2; i < n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            }
        }

        //////////////////////////////////////////////////
        
     
        public static void OutputEvenNumbers()
        {

            mutex.WaitOne();
            string txt = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {

                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(i);
                    txt += i + " ";


                }
            }

            mutex.ReleaseMutex();
            File.AppendAllText(name_file, txt);

        }

        public static void OutputOddNumbers()
        {
            mutex.WaitOne();
            string txt = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
                {

                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Red;
                    txt += i + " ";
                    Console.WriteLine(i);


                }
            }
            mutex.ReleaseMutex();
            Console.ForegroundColor = ConsoleColor.White;
            File.AppendAllText(name_file, txt);

        }
        public static void TwoThreads()
        {
            

            Thread thread_first = new(OutputEvenNumbers);
            thread_first.Start();
            thread_first.Priority = ThreadPriority.Normal;



            Thread thread_second = new(OutputOddNumbers);
            thread_second.Start();
            thread_second.Priority = ThreadPriority.Normal;



        }

        public static void ReadFile()
        {
            var file = File.ReadAllText(name_file);

            Console.WriteLine(file);

        }

        public static void Timer()
        { 

        TimerCallback tm = new TimerCallback(ShowTime);
        Timer timer = new Timer(tm, 0, 0, 1000);
        Console.ReadKey();
        timer.Dispose();



    }

    public static void ShowTime(object obj)
    {
        Console.WriteLine(DateTime.Now);
    }

    }
}

    

    

