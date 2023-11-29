using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("length == n(8)\n");
            int n = 8;
            string[] mounths = {  "January", "February", "March", "April", "May", "June", "July",
                                "August", "September", "October", "November", "December" };
            IEnumerable<string> result1 = from mon in mounths
                                          where mon.Length == n
                                          select mon;
            foreach (string res1 in result1)
                Console.WriteLine(res1);
            Console.WriteLine("\nlenth >= 4||u\n");
            IEnumerable<string> result2 =
                mounths.Where(p => p.Contains("u") && p.Length >= 4);
            foreach (string res2 in result2)
                Console.WriteLine(res2);
            Console.WriteLine("\nSummer and Winter\n");
            string[] winterAndSummerMonth = { "June", "July", "August", "December", "January", "February" };
            IEnumerable<string> resultMonth = mounths.Intersect(winterAndSummerMonth);
            foreach (string selMonth in resultMonth) 
                Console.WriteLine(selMonth);
                Console.WriteLine("\nAlphabet\n");
            IEnumerable<string> alpha = from i in resultMonth
                                        orderby i ascending
                                        select i;
            foreach(string alphabet in alpha)
                Console.WriteLine(alphabet);
            Console.WriteLine("\nHouse\n");
            //Task 2-3
            List<House> houses = new List<House>();
            houses.Add(new House(78, 23.4, 7, 2, "Ул.Минская", "Квартира", 60));          // 1
            houses.Add(new House(51, 15.89, 5, 2, "Ул.Новосельская", "Частный дом", 120));// 2
            houses.Add(new House(216, 30, 2, 3, "Ул.Ленинская", "Частный дом", 135));     // 3
            houses.Add(new House(93, 29.5, 9, 3, "Ул.Желтовского", "Квартира"));          // 4
            houses.Add(new House(168, 8.25, 1, 1, "Ул.Военная", "Общежитие", 120));       // 5
            houses.Add(new House(99, 8.25, 1, 1, "Ул.Бобруйская", "Общежитие", 170));       // 6
            houses.Add(new House(168, 8.25, 1, 2, "Ул.Белорусская", "Общежитие", 190));       // 7
            houses.Add(new House(168, 8.25, 5, 2, "Ул.Бобруйская", "Общежитие", 122));       // 8
            houses.Add(new House(168, 8.25, 1, 1, "Ул.Белорусская", "Общежитие", 100));       // 9
            houses.Add(new House(168, 8.25, 6, 3, "Ул.Пинская", "Общежитие", 105));       // 10
            houses.Add(new House(168, 8.25, 1, 1, "Ул.Бобруйская", "Общежитие", 115));       // 11
            foreach (House dom in houses)
                House.showInfo(dom);
             Console.WriteLine("|------------- Список квартир, имеющих заданное число комнат -------------|");

             int m = Convert.ToInt32(Console.ReadLine());
             IEnumerable<House> rooms = from selectedRooms in houses
                                        where selectedRooms.NumberOfRooms == m
                                        select selectedRooms;
             foreach(House rom in rooms)
                 House.showInfo(rom);
            Console.WriteLine("|------------- Пять первых квартир на заданной улице заданного дома -------------|");

            string streetName = "Ул.Бобруйская";
            IEnumerable<House> fiveFirstHouses = from hs in houses
                                                 where hs.Street == streetName
                                                 select hs;

            IEnumerable<House> fiveFiveLastHouses = fiveFirstHouses.Take(5);
            foreach (House home in fiveFiveLastHouses)
                House.showInfo(home);

            Console.WriteLine("|------------- Количество квартир на определённой улице -------------|");
            Console.WriteLine("Ул.Белорусская:\n ");
            string thatStreet = "Ул.Белорусская";
            int kolvo = (from kal in houses
                         where kal.Street == thatStreet
                         select kal).Count();
            Console.WriteLine(kolvo);

            Console.WriteLine("|------------- Список квартир, имеющих заданное число комнат и находящихся в заданном промежутке этажей -------------|\nВведите количество комнат: ");
            int k = Convert.ToInt32(Console.ReadLine());
            IEnumerable<House> housesWithRoomsAndFloor = houses.Where(hs => hs.NumberOfRooms == k && (hs.Floor > 1 && hs.Floor < 6));
            foreach (House home in housesWithRoomsAndFloor)
                House.showInfo(home);

            //Task4

            IEnumerable<IGrouping<string, House>> unicListLINQ = from uniHome in houses
                                                                 where uniHome.NumberOfRooms > 1
                                                                 orderby uniHome.Street ascending
                                                                 group uniHome by uniHome.Street;

            foreach (var streetHome in unicListLINQ)
            {
                Console.WriteLine(streetHome.Key);
                foreach (var Home in streetHome)
                    Console.WriteLine(Home.NumberOfRooms);
                Console.WriteLine();
            }

            bool allHasMore50Years = houses.All(hs => hs.ServiceLife > 50);
            Console.WriteLine(allHasMore50Years);

            IEnumerable<House> takeGroup = houses.Take(2);
            foreach (House home in takeGroup)
                House.showInfo(home);

            IEnumerable<string> streets = (from hs in houses
                                           select hs.Street).Distinct();
            Console.WriteLine("|------------------------------------------|");
            foreach (string stree in streets)
                Console.WriteLine(stree);

            // Task 5
            Console.WriteLine("\n------------------Task 5-----------------------\n");
            Student[] students =
            {
                new Student("Лёша", "БГТУ"), new Student("Саша", "БГУ"),
                new Student("Вася", "БНТУ"), new Student("Ваня", "БГУ"),
            };

            University[] universitys =
            {
                new University("БГУ", "Python"),
                new University("БГТУ", "C#"),
                new University("БНТУ", "Java")
            };
            var employees = from p in students
                            join c in universitys on p.Company equals c.Title
                            select new { Name = p.Name, Company = c.Title, Language = c.Language };

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");

        }
        public class Student
        {
            public string Name { get; set; }
            public string Company { get; set; }
            public Student(string name, string company)
            {
                Name = name;
                Company = company;
            }
        }
        public class University
        {
            public string Title { get; set; }
            public string Language { get; set; }

            public University(string title, string language)
            {
                Title = title;
                Language = language;
            }
        }

    }

}
    
