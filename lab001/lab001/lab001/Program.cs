using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab001
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fla = true;
            Console.WriteLine($"bool = {fla}");
            Console.WriteLine("Enter string");
            string line = Console.ReadLine();
            Console.WriteLine($"string = { line}");
            byte b = 63; // 0-255 1b
            Console.WriteLine($"byte = {b}");
            sbyte sb = -34; // -128-127 1b
            Console.WriteLine($"sbyte = {sb}");
            short number = 123; //-32768-32767
            Console.WriteLine($"sort = {number}");
            ushort number1 = 34; //0-65535
            Console.WriteLine($"ushort = { number1}");
            int a = 6;
            Console.WriteLine($"int = {a}");
            long l = -1234567L;
            Console.WriteLine($"long = {l}");//8b
            ulong ul = 12345678UL;
            Console.WriteLine($"ulong = {ul}");
            float f = 3.14F;
            Console.WriteLine($"float = {f}");
            double d = 78.91;
            Console.WriteLine($"double = {d}");
            decimal mal = -67.91M;//16b
            Console.WriteLine($"decimal = {mal}");
            Console.WriteLine("Enter object");
            object obj = Console.ReadLine();
            Console.WriteLine($"object = {obj}");


//zd2
// не явное расширяющее преобразование от типа с меньшей разрядностью к типу с большей
            byte a1 = 4;
            short b1 = a1;
            Console.WriteLine($"byte -> short\na = {a1}, b = {b1}");
            int c = -8;
            double d1 = c;
            Console.WriteLine($"int -> double\nc = {c}, d = {d1}");
            long l1 = c;
            Console.WriteLine($"int -> long\nc = {c}, l = {l1}");
            c = b1;
            Console.WriteLine($"short -> int\nc = {c}, b = {b1}");
            float f1 = 3.7F;
            d1 = f1;
            Console.WriteLine($"float -> double\nf = {f1}, d = {d1}");
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //явное преобразование 
            int n = Convert.ToInt32("23");
            bool z = true;
            double x = Convert.ToDouble(z);
            int one = 1;
            bool flag = Convert.ToBoolean(one);
            char ch = (char)(one);
            Console.WriteLine($"n={n}  d={x}, flag={flag}, ch={ch}");

            Console.WriteLine("-----------------------------------------------------------------\n ");
            //работа с неявно типизированной переменной
            var www = a + b;
            Console.WriteLine(www);
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //упаковка и распаковка 
            int i = 123;
            object o = i;
            int j = (int)o;
            Console.WriteLine(j);
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //nullable переменная
            int? namber1 = null;
            Nullable<int> number2 = null;
            Console.WriteLine($"number2={number2}, number1={namber1}");
            Console.WriteLine("-----------------------------------------------------------------\n ");
           var myVar = 10; // myVar будет иметь тип int
           //myVar = "Hello"; // Это вызовет ошибку компиляции, так как тип уже определён как int


                           ///////////////////////////////////zd3
            string first = "exal Greka ";
            string second = "chez reku ";
            Console.WriteLine($"Сравнение строк:\nfirst = second -{first == second}\n");
            string third = "vidit_Greka_v_rerke rak";
            Console.WriteLine($"{string.Concat(first, second, third)} - сцепление\n");
            string podstroka = third.Substring(6, 8);
            Console.WriteLine($"{podstroka} - выделение подстроки");
            var fou = string.Copy($"{first} - копирование");                     //копирование
            Console.WriteLine(fou);
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
            Console.WriteLine($"\n{first.Insert(5, "Hello ")} - вставка подстроки");
            Console.WriteLine($"\n{first.Remove(0, 4)} - удаление подстроки");
            Console.WriteLine("\n" + "Пустая и null строка");
            string str = "";
            string str1 = null;
            Console.WriteLine(string.IsNullOrEmpty(str));
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine("\n Использование StringBuider");
            StringBuilder sbb = new StringBuilder("PerLoNu", 50);
            sbb.Append(new char[] { 's', 'p', 'o', 'i', 'v', 'o', 'j' });
            sbb.Insert(0, "Ya");
            sbb.Remove(5, 2);
            Console.WriteLine(sbb);

            //////////////////////////////////////////////////zd4
            Console.WriteLine("\n" + "Двумерный массив");
            int[,] numbers = { { 8, 2, 35 }, { 4, 15, 64 } };
            int rows = numbers.GetUpperBound(0) + 1;    // количество строк
            int columns = numbers.Length / rows;        // количество столбцов

            for (int cnt = 0; cnt < rows; cnt++)
            {
                for (int j2 = 0; j2 < columns; j2++)
                {
                    Console.Write($"{numbers[cnt, j2]}" + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
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
            int[][] x1 = new int[3][];

            // Заполняем каждую "строку" в ступенчатом массиве собственным массивом чисел.
            Console.Write("Введите количество строк: ");
            int rowCount = int.Parse(Console.ReadLine());

            // Создаем ступенчатый массив
            int[][] jaggedArray = new int[rowCount][];

            // Заполняем массив данными
            for (int k = 0; k < rowCount; k++)
            {
                Console.Write($"Введите количество элементов для строки {k + 1}: ");
                int columnCount = int.Parse(Console.ReadLine());

                jaggedArray[k] = new int[columnCount];

                Console.WriteLine($"Введите {columnCount} элементов для строки {k + 1}:");

                for (int cc = 0; cc < columnCount; cc++)
                {
                    Console.Write($"Элемент {cc + 1}: ");
                    jaggedArray[k][cc] = int.Parse(Console.ReadLine());
                }
            }

            // Выводим содержимое ступенчатого массива
            Console.WriteLine("Вы ввели следующий ступенчатый массив:");

            for ( i = 0; i < rowCount; i++)
            {
                for ( int jj = 0; jj < jaggedArray[i].Length; jj++)
                {
                    Console.Write(jaggedArray[i][jj] + " ");
                }
                Console.WriteLine();
            }
        

        Console.WriteLine("Неявно типизированные переменные для хранения массива и строки\n");
            var p1 = "Poka, mir";
            var p2 = new[] { 1, 2, 3, 4, 5 };
            for (int i2 = 0; i2 < p2.Length; i2++)
            {
                Console.Write($"{p2[i2]} ");
            }
            Console.WriteLine(p1);
            Console.WriteLine( "\n" +"Работа с кортежами:\n");
            ValueTuple<int, string, char, string, ulong> student = (24, "kukd", 'k', "lol", 12345678);
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
            Console.WriteLine("\nЛокальная функция");

             (int, int, int, char) LocalFunction(int[] arrVar, string strVar)
            {
                int maxArrayElement = arrVar.Max();
                int minArrayElement = arrVar.Min();
                int arrayElementsSum = arrVar.Sum();
                char firstStringChar = strVar[0];
                return (maxArrayElement, minArrayElement, arrayElementsSum, firstStringChar);
            }
            int[] myArray = { 10, 5, 20, 15 };
            string myString = "Hello";

            (var max, var min, var sum, var firstChar) = LocalFunction(myArray, myString);

            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Первый символ строки: {firstChar}");

            //----------Работа с checked/unchecked------------
            Console.WriteLine("Работа с checked/unchecked");
            void CheckedFunc()
            {
                checked
                {
                    int Max = int.MaxValue;
                   /* Console.WriteLine(Max);
                    Max+=1;*/
                    Console.WriteLine($"Checked:\n{Max}");

                }
            }
            void Unchecked()
            {
                unchecked
                {
                    int Max = int.MaxValue;
                    Console.WriteLine($"Unchecked:\n{Max}");
                    Max += 1;
                    Console.WriteLine($"Unchecked:\n{Max}");
                }
            }
            CheckedFunc();
            Unchecked();
        }
    

}
    }

