using Lab_9_NET;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace Lab_9_NET
{

    public class MainClass
    {
        public static void Main()
        {
            Console.WriteLine($"\n|---------- Task1 ----------|");
            Software software1 = new Software("Прикладное", 30);
            Software software2 = new Software("Прикладное", 25);
            Software software3 = new Software("Прикладное", 40);
            Software software4 = new Software("Системное", 100);
            Software software5 = new Software("Прикладное", 5);

            MyCollection<Software> myCollection = new();
            myCollection.Add(software1);
            myCollection.Add(software2);
            myCollection.Add(software3);
            myCollection.Add(software4);
            myCollection.Add(software5);

            myCollection.Print(0);
            myCollection.Print(1);
            myCollection.Print(2);
            myCollection.Print(3);
            myCollection.Print(4);

            Console.WriteLine($"Кол-во элементов: {myCollection.Count}");

            myCollection.Remove(software2);
            Console.WriteLine($"Кол-во элементов после удаления: {myCollection.Count}");

            myCollection.Print(0);
            myCollection.Print(1);
            myCollection.Print(2);
            myCollection.Print(3);
            Console.WriteLine($"\n|---------- Task2 ----------|");
            // Task 2
            SortedList<int, string> intSortedList = new SortedList<int, string>();
            intSortedList.Add(2, "Белодед");
            intSortedList.Add(4, "Миксер");
            intSortedList.Add(8, "Культурный код");
            intSortedList.Add(999, "Микроволновка");
            intSortedList.Add(78, "Помидор");
            intSortedList.Add(16, "Танк");
            foreach (var pair in intSortedList)
            {
                Console.WriteLine($"Ключ: {pair.Key}, Значение: {pair.Value}");
            }
            Console.WriteLine('\n');
            

            void RemoveRange(SortedList<int, string> sortedList, int startIndex, int count)
            {
                if (startIndex < 0 || startIndex >= sortedList.Count || count <= 0)
                {
                    Console.WriteLine("Недопустимые параметры для удаления.");
                    return;
                }

                int endIndex = startIndex + count - 1;
                if (endIndex >= sortedList.Count)
                {
                    Console.WriteLine("Выход за пределы коллекции.");
                    return;
                }

                for (int i = startIndex; i <= endIndex; i++)
                {
                    sortedList.RemoveAt(startIndex);
                }
            }
            RemoveRange(intSortedList, 1, 3);
            Console.WriteLine("После удаления:\n");
            foreach (var pair in intSortedList)
            {
                Console.WriteLine($"Ключ: {pair.Key}, Значение: {pair.Value}");
            }
            Console.WriteLine('\n');

           
            List<KeyValuePair<int, string>> secondCollection = new List<KeyValuePair<int, string>>();
            foreach (var item in intSortedList)
            {
                secondCollection.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }
            secondCollection.Add(new KeyValuePair<int, string>(3, "wedrgh"));

            Console.WriteLine("Вторая коллекция:\n");
            foreach (var item in secondCollection)
            {
                Console.WriteLine($"Ключ: {item.Key}, Значение: {item.Value}");
            }

            Console.Write("Введите ключ для поиска: ");
            int keyToFind = Convert.ToInt32(Console.ReadLine());

            KeyValuePair<int, string> foundItem = secondCollection.Find(item => item.Key == keyToFind);

            if (foundItem.Key != 0)
            {
                Console.WriteLine("\t-KEY-\t-VALUE-");
                Console.WriteLine($"\t {foundItem.Key}\t {foundItem.Value}");
            }
            else
            {
                Console.WriteLine("Данных с таким ключом нет.");
            }


            Console.WriteLine($"\n|---------- Task3 ----------|");
            // Task 3
            ObservableCollection<Software> softwares = new ObservableCollection<Software>();
            softwares.Add(software1);
            softwares.Add(software2);
            softwares.Add(software3);
            softwares.Add(software4);
            softwares.Add(software5);

          
            softwares.CollectionChanged += softwares_CollectionChanged;

            softwares.Add(new Software("ПО1ТЕСТ", 45)); 

            softwares.RemoveAt(1);                 
            softwares[0] = new Software("ПО2ТЕСТ", 33);  

            Console.WriteLine("\nСписок ПО:");
            foreach (var software in softwares)
            {
                software.Print();
            }
           
            void softwares_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        if (e.NewItems?[0] is Software newSoftware)
                            Console.WriteLine($"Добавлено новое ПО: \"{newSoftware.TypeOfSoftware}\"");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        if (e.OldItems?[0] is Software oldSoftware)
                            Console.WriteLine($"Удалено ПО: \"{oldSoftware.TypeOfSoftware}\"");
                        break;
                    case NotifyCollectionChangedAction.Replace: // если замена
                        if ((e.NewItems?[0] is Software replacingSoftware) &&
                            (e.OldItems?[0] is Software replacedSoftware))
                            Console.WriteLine($"ПО \"{replacedSoftware.TypeOfSoftware}\" заменено на ПО \"{replacingSoftware.TypeOfSoftware}\"");
                        break;
                }
            }
        }
    }
}