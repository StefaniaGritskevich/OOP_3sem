using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public static class StatisticOperations
    {
        // методы расширения

        // Метод для шифрования строки с использованием сдвига символов
        public static string Encrypt(this string input, int shift)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    chars[i] = (char)((c + shift - offset) % 26 + offset);//берём по модулю 26 чтобы оставаться в пределах алфавита
                }
            }
            return new string(chars);
        }

        // Метод для проверки, является ли множество упорядоченным
        public static bool IsOrdered<T>(this CustomSet<T> set) where T : IComparable<T>
        {
            if (set.Count < 2)
            {
                return true; // Множество с 0 или 1 элементом всегда упорядочено
            }

            for (int i = 1; i < set.Count; i++)
            {
                if (set[i].CompareTo(set[i - 1]) < 0)
                {
                    return false; // Не упорядочено, так как элементы не в порядке возрастания
                }
            }

            return true; // Все элементы упорядочены
        }
    }


}