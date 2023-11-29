using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    partial class House
   {
        private readonly Guid id;
        private string street;
        private int number;
        private int floor;
        private int square;
        private int roomsAmount;
        private string houseType;
        private int years;
        //статическое поле
        public static short count = 0;

        public Guid ID
        {
            get { return id; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Floor
        {
            get { return floor; }
            set {
                if (value < 0 && value > 16)
                {
                    Console.WriteLine("Непривильно введён этаж, отсчёт этажей начинается с 1 по 15");
                }
                else
                {
                    floor = value;
                }
            }
        }
        public int Square
        {
            get { return square; }
            set { square = value; }
        }
        public int RoomsAmount
        {
            get { return roomsAmount; }
            set { roomsAmount = value; }
        }
        public string HouseType
        {
            get { return houseType; }
            set { houseType = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        //конструктор с параметрами 
        public House(string Astreet, int Anumber, int Afloor,int Asquare,int AroomsAmount,string AhouseType, int Ayears)
        {
            id = GetHashCode();
            street = Astreet;
            number = Anumber;
            floor = Afloor;
            square = Asquare;
            roomsAmount = AroomsAmount;
            houseType = AhouseType;
            years = Ayears;
            count++;
        }
        //конструктор без парамеров
        public House()
        {
            id = GetHashCode();
            street = "Неизвестно";
            number = 0;
            floor = 0;
            square = 0;
            roomsAmount = 0;
            houseType = "Неизвестно";
            years = 0;
            count++;
        }

        private House( Guid id)
        {
            this.id = id;
            number = 87;
            floor = 1;
            square = 56;
            roomsAmount = 3;
            houseType = "Новый";
            years = 2;
            count++;
        }
        public static House CreateInstance()
        {
            return new House(GetHashCode());
        }
        static House()
        {
            count = 0;
        }
        //поле константа
        public const string city = "Минск";
        public const string sity = "";
        //------------------------------------------------------------
        //метод дщля вывода информации

        public override string ToString()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Номер квартиры: " + number);
            Console.WriteLine("Этаж: " + floor);
            Console.WriteLine("Площадь: " + square + "м^2");
            Console.WriteLine("Количество комнат: " + roomsAmount);
            Console.WriteLine("Тип здания : " + houseType);
            Console.WriteLine("Срок эксплуатации: " + years);
            Console.WriteLine("Город: " + city);
            return sity;
        }

        public int Age(ref int years)
        {
            years = 10 + years;
            Console.WriteLine("Возраст здания: " + years);
            if(years > 60)
            {
                Console.WriteLine("Здание нуждается в капитальном ремонте, скоро развалимся!");
            }
            else
            {
                Console.WriteLine("А чего жалуемся? Жить можно");
            }
            return years;
        }

        //расчет уникального номера
        public static Guid GetHashCode()
        {
            return Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            House stud = obj as House;
            if (stud == null)
                return false;
            return this.RoomsAmount == stud.RoomsAmount;
        }
    }
}
