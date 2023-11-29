/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab001
{
    class zd22
    {
        static void Main(string[] args)
        {
            string first = "exal Jewrei ";
            string second = "chez reku ";
            Console.WriteLine($"first = second -{first == second}");
            string third = "vidit_Jewrei_v_rerke rak";
            Console.WriteLine($"{string.Concat(first, second,third)} - сцепление");
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
            string str = string.Empty;
            string str1 = null;
            Console.WriteLine(string.IsNullOrEmpty(str));
            Console.WriteLine(string.IsNullOrEmpty(str1));
            StringBuilder sb = new StringBuilder("PerLoNu", 50);
            sb.Append(new char[] { 's', 'p', 'o', 'd', 'l', 'i', 'v', 'o', 'j' });
            sb.Insert(0, "Ya");
            sb.Remove(5, 2);
            Console.WriteLine(sb);

        }

    }
}
*/