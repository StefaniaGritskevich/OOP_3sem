using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class CustomSet<T> : Interface1<T> where T : Exam
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

        public int Search()
        {
            int fails = 0;
            foreach(T item in items)
            {
                if(item != null && item.Grade < 4)
                {
                    fails++;
                }
            }
            return fails;
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

        public int CountElements()
        {
            return count;
        }



    }
}
