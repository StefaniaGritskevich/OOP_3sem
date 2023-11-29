using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab03
{
    public class CustomSet<T>
    {
        public T[] items;
        private int count;
        private Random random;

        public CustomSet()
        {
            items = new T[10]; 
            count = 0;
            random = new Random();

        }

        public int Count
        {
            get { return count; }
        }

        public void Add(T item)
        {
            if (!Contains(item))
            {
                if (count == items.Length)
                {
                    // Если массив заполнен, увеличиваем его размер вдвое
                    Array.Resize(ref items, items.Length * 2);
                }

                items[count] = item;
                count++;
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    // Перемещаем последний элемент на место удаляемого элемента
                    items[i] = items[count - 1];
                    items[count - 1] = default(T);
                    count--;
                    return;
                }
            }
        }

       

        public override string ToString()
        {
            string result = "{ ";
            for (int i = 0; i < count; i++)
            {
                result += items[i];
                if (i < count - 1)
                {
                    result += ", ";
                }
            }
            result += " }";
            return result;
        }


        public static CustomSet<T> operator +(CustomSet<T> set1, CustomSet<T> set2)
        {
            CustomSet<T> result = new CustomSet<T>();

            foreach (T item in set1.items)
            {
                result.Add(item);
            }

            foreach (T item in set2.items)
            {
                result.Add(item);
            }

            return result;
        }

        public static CustomSet<T> operator ++(CustomSet<T> set)
        {
            int randomValue = set.random.Next();
            set.Add((T)(object)randomValue);
            return set;
        }

        public static bool operator <=(CustomSet<T> set1, CustomSet<T> set2)
        {
            // Проверяем, что все элементы множества set1 присутствуют в множестве set2
            foreach (T item in set1.items)
            {
                if (!set2.Contains(item))
                {
                    return false; // Найден элемент, который не присутствует во втором множестве
                }
            }

            return true; // Все элементы множества set1 присутствуют во втором множестве set2
        }

        public static bool operator >=(CustomSet<T> set1, CustomSet<T> set2)
        {
            // Проверяем, что все элементы множества set1 присутствуют в множестве set2
            foreach (T item in set1.items)
            {
                if (!set2.Contains(item))
                {
                    return false; // Найден элемент, который не присутствует во втором множестве
                }
            }

            return true; // Все элементы множества set1 присутствуют во втором множестве set2
        }

        public static implicit operator int(CustomSet<T> set5)
        {
            return set5.Count;
        }

       public static T operator %(CustomSet<T> set, int index)
{
    if (index < 0 || index >= set.count)
    {
        throw new ArgumentOutOfRangeException("index", "Индекс находится вне диапазона.");
    }

    return set.items[index];
}

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("index", "Индекс находится вне диапазона.");
                }

                return items[index];
            }
        }







        public class Production
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public class Developer
            {
                public string Fio { get; set; }
                public int Id { get; set; }
                public string Department { get; set; }

            }




        }

        public T Sum()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Множество пусто, нельзя вычислить сумму.");
            }

            dynamic sum = items[0]; // Инициализируем переменную sum значением первого элемента

            for (int i = 1; i < count; i++)
            {
                // Предполагается, что элементы множества можно складывать с помощью оператора "+"
                sum += items[i];
            }

            return sum;
        }

        public T Min()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Множество пусто, нельзя найти минимум.");
            }

            T min = items[0];

            for (int i = 1; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(items[i], min) < 0)
                {
                    min = items[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Множество пусто, нельзя найти максимум.");
            }

            T max = items[0];

            for (int i = 1; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(items[i], max) > 0)
                {
                    max = items[i];
                }
            }

            return max;
        }

        public T raznost()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Множество пусто, нельзя вычислить разность.");
            }

            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(decimal))
            {
                T min = Min(); 
                T max = Max(); 

                dynamic minDynamic = min;
                dynamic maxDynamic = max;

                return maxDynamic - minDynamic;
            }
            else
            {
                throw new InvalidOperationException("Тип элементов множества не поддерживает операцию вычитания.");
            }
        }

        public int CountElements()
        {
            return count;
        }
       


    }



}



