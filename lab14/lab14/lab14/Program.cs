using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n-------Задание 1-------\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Help.ShowProces();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n-------Задание 2-------\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Help.ShowDomain();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n-------Задание 3-------\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Help.ShowNumbers();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n-------Задание 4-------\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Help.TwoThreads();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Help.Timer();

        }
    }
}
