/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab001
{
    class zd3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "Двумерный массив");
            int[,] numbers = { { 8, 2, 35 }, { 4, 15, 64 } };
            int rows = numbers.GetUpperBound(0) + 1;    // количество строк
            int columns = numbers.Length / rows;        // количество столбцов

            for (int cnt = 0; cnt < rows; cnt++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[cnt, j]}" + "  ");
                }
                Console.WriteLine();
            }
            string[] lines = { "One", "Two", "Tree" };
            for (int cnt1 = 0; cnt1 < lines.Length; cnt1++)
            {
                Console.Write("{0} ", lines[cnt1]);
            }
            Console.WriteLine($"\nДлина массива - {lines.Length}");
            Console.WriteLine("Введите номер элемента массива:");
            int index = int.Parse(Console.ReadLine());
            if (index >= lines.Length)
                throw new ArgumentOutOfRangeException();
            Console.WriteLine("Введите новое значение элемента массива:");
            string value = Console.ReadLine();
            lines[index] = value;
            Console.WriteLine("Массив после изменения:");
            for (int cnt1 = 0; cnt1 < lines.Length; cnt1++)
            {
                Console.Write("{0} ", lines[cnt1]);
            }
            Console.WriteLine();

            // Создаем ступенчатый массив с тремя "строками", где каждая "строка" - это массив целых чисел.
            int[][] x = new int[3][];

            // Заполняем каждую "строку" в ступенчатом массиве собственным массивом чисел.
            x[0] = new int[] { 1, 2, 3 };
            x[1] = new int[] { 4, 5 };
            x[2] = new int[] { 6, 7, 8, 9 };

            for(int i = 0; i < x.Length; i++)
            {
                Console.Write("Строка {0}: ", i);
                for (int j = 0; j < x[i].Length;j++)
                Console.Write(x[i][j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Неявно типизированные переменные для хранения массива и строки\n");
            var p1 = "Poka, mir";
            var p2 = new[] { 1, 2, 3, 4, 5 };
            for(int i = 0; i < p2.Length; i++)
            {
                Console.Write($"{p2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine( p1);
            ValueTuple<int, string, char, string, ulong> student = (24, "kukold", 'k', "loh", 12345678);
            Console.WriteLine(student);
            Console.WriteLine(student.Item4);
            Console.WriteLine(student.Item1);
            var (t_1, t_2, t_3, t_4, t_5) = student;
            Console.WriteLine(t_1);
            Console.WriteLine(t_2);
            Console.WriteLine(t_3);
            Console.WriteLine(t_4);
            Console.WriteLine(t_5);
            //исп переменной
            //------использование переменной(_)---------------
            Console.WriteLine("\nИспользование переменной(_)");
            var (f_1, _, _, j_1, _) = student;
            Console.WriteLine(f_1);
            Console.WriteLine(j_1);
            //----------- cравнение двух кортежей--------------
            Console.WriteLine("\nСравнение двух кортежей");
            var tuple1 = (1, "Two", '3', "Four", 5ul);
            Console.WriteLine($"{student == tuple1}");
            //----------- Локальная функция -------------------
            *//*Console.WriteLine("\nЛокальная функция");

            static (int, int, int, char) LocalFunction(int[] arrVar, string strVar)
            {
                int maxArrayElement = arrVar.Max();
                int minArrayElement = arrVar.Min();
                int arrayElementsSum = arrVar.Sum();
                char firstStringChar = strVar[0];
                return (maxArrayElement, minArrayElement, arrayElementsSum, firstStringChar);
            }
*//*
            //----------Работа с checked/unchecked------------
            Console.WriteLine("Работа с checked/unchecked");
            void CheckedFunc()
            {
                checked
                {
                    int Max = int.MaxValue;
                   // Max+=1;
                    Console.WriteLine(Max);

                }
            }
            void Unchecked()
            {
                unchecked
                {
                    int Max = int.MaxValue;
                   // Max += 1;
                    Console.WriteLine(Max);
                }
            }
            CheckedFunc();
            Unchecked();
        }
    }
    }

*/