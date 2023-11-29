using lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            House[] house = new House[6];
            //полный конструктор
            house[0] = new House ("Кирова", 65, 4, 123, 3, "Новый", 79);
            house[1] = new House("Крирова", 6, 5, 1200, 3, "Старый", 79);
            house[2] = new House("Крирова", 3, 8, 23, 1, "Относительно новый", 79);
            house[3] = new House("Белорусская", 21, 1206, 12367, 6, "Сейчас разввалиться", 790);
            house[4] = new House("Бенгальская", 45, 14, 1323, 2, "Не достроен", 1);
            //конструктор без параметров
            house[5] = new House();
            //private
            House house3 = House.CreateInstance();

            for (int p = 0; p < house.Length; p++)
            {
                Console.WriteLine("Здание №" + (p + 1));
                Console.WriteLine(house[p].ToString());
                Console.WriteLine("\n");
            }
            Console.WriteLine("Закрытый конструктор\n");
            Console.WriteLine("ID: " + house3.ID);
            Console.WriteLine("Улица: " + house3.Street);
            Console.WriteLine("Номер квартиры: " + house3.Number);
            Console.WriteLine("Этаж: " + house3.Floor);
            Console.WriteLine("Площадь: " + house3.Square + "м^2");
            Console.WriteLine("Количество комнат: " + house3.RoomsAmount);
            Console.WriteLine("Тип здания : " + house3.HouseType);
            Console.WriteLine("Срок эксплуатации: " + house3.Years);
            int kv, floor7;
            Console.WriteLine("Поиск по количеству комнат\nВведите количество комнат: ");
            kv = Convert.ToInt32(Console.ReadLine());

            foreach(House house_ in house)
            {
                if(house_.RoomsAmount == kv)
                {
                    house_.ToString();
                        Console.WriteLine("-------------------------------------------------");
                }
                
               
            }
            Console.WriteLine("Поиск по количеству комнат на этажах с 7 по 12 \nВведите количество комнат: ");
            kv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите этаж с 7 по 12");
            floor7 = Convert.ToInt32(Console.ReadLine());
          
            foreach (House house_ in house)
            {
                if (house_.RoomsAmount == kv && floor7 > 6 && floor7 < 13)
                {
                    house_.ToString();
                    Console.WriteLine("-------------------------------------------------");
                }
            }
            Console.WriteLine("Введите номер сдания, чтобы узнать нуждается ли оно в ремонте: ");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            int starost = house[i - 1].Years;
            int age = house[i - 1].Age(ref starost);
            Console.WriteLine("-------------------------------------------------");

            //сравнение объектов
            int k,l;
            Console.WriteLine("Введите номера зданий которые хотите сравнить ко количеству комнат в квартире: ");
            k = Convert.ToInt32(Console.ReadLine());
            l = Convert.ToInt32(Console.ReadLine());
            if (house[k -1].Equals(house[l - 1]))
                Console.WriteLine("\n\n   1-ая и 2-ая квартиры одинаковые.");
            else
                Console.WriteLine("\n\n   1-ая и 2-ая квартиры  не одинаковые.");

            var Anonim = new { Street = "Гагарина", House = 34 };
            Console.WriteLine("\nАнонимный тип\n" + Anonim.Street + " " + Anonim.House);
        }
    }
}
