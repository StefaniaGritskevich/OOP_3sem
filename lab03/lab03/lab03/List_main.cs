using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class List_main
    {
        static void Main(string[] args)
        {
            CustomSet<int> mySet = new CustomSet<int>();

            mySet.Add(1);
            mySet.Add(2);
            mySet.Add(3);

            Console.WriteLine("Множество1: " + mySet.ToString());

            CustomSet<int> secSet = new CustomSet<int>();
            secSet.Add(0);
            secSet.Add(6);
            secSet.Add(8);
            secSet.Add(9);
            secSet.Add(12);

            Console.WriteLine("Множество2: " + secSet.ToString());

            CustomSet<int> newSet = mySet + secSet;
            Console.WriteLine("Объединение множеств: " + newSet.ToString());
            CustomSet<int> randSet = mySet++;

            Console.WriteLine("Добавление рандомного элемента: " + randSet.ToString());

            Console.WriteLine($"Сравнение 2 множеств:\n{mySet}\n{secSet} :");
            Console.WriteLine(mySet <= secSet);

            int power = mySet;
            Console.WriteLine("Мощность множества: " + power);

            int elementAtIndex2 = mySet % 2; // Получение элемента по индексу 2 (третий элемент)

            Console.WriteLine("Элемент множества по индексу 2: " + elementAtIndex2);
            // Console.ReadLine();

            CustomSet<int>.Production production = new CustomSet<int>.Production();
            production.Id = 1;
            production.Name = "Минск";
            Console.WriteLine(production.Id);
            Console.WriteLine(production.Name);

            CustomSet<int>.Production.Developer developer = new CustomSet<int>.Production.Developer();
            developer.Fio = "Грицкевич Стефания Александровна";
            developer.Id = 1;
            developer.Department = "ФИТ БГТУ";
            Console.WriteLine(developer.Id);
            Console.WriteLine(developer.Fio);
            Console.WriteLine(developer.Department);
            Console.WriteLine("\n--------------------------------------\n");




           Console.WriteLine($"Сумма всех элементов множества: {secSet.Sum()}");
            Console.WriteLine($"Разность максимального и минимального: {secSet.raznost()}");
            Console.WriteLine($"Количество элементов множества: {secSet.CountElements()}");



            CustomSet<int> unorderedSet = new CustomSet<int>();
            unorderedSet.Add(3);
            unorderedSet.Add(2);
            unorderedSet.Add(1);
            unorderedSet.Add(5);
            unorderedSet.Add(0);

            Console.WriteLine("\n--------------------------------------\nМетоды расширения");
            bool isOrdered1 = mySet.IsOrdered(); // Вернет true, так как множество orderedSet упорядочено.
            bool isOrdered2 = unorderedSet.IsOrdered(); // Вернет false, так как множество unorderedSet не упорядочено.
            Console.WriteLine($"Множество mySet упорядочено: {isOrdered1}");
            Console.WriteLine($"Множество unorderedSet упорядочено: {isOrdered2}");

            string inputString = "Hello";
            string encryptedString = inputString.Encrypt(1); // Зашифрованная строка
            Console.WriteLine(encryptedString);

        }
    }
}
