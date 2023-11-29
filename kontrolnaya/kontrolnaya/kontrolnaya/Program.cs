using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolnaya
{
    class Program
    {
        static void Main(string[] args)
        {
           ///////////////////////zd1A
             Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char lastChar = input[input.Length - 1];
                string res = input + lastChar;

                Console.WriteLine("Результат: " + res);
            }

            ///////////////////////zd1B
            int[,] arr = new int[,] { {1,2,3,-3 },{-1,-2,-4,-5 },
                                    {-2,0,-9,-5 },{1,2,3,4 } };

            int i = 0;
            foreach (int a in arr) {
                if (a > 0)
                    i++;
                    }
            Console.WriteLine("Количество положительных:" + i);




            ///////////////////////////////zd2
            try
            {
                var my = new Mycollection<int>();
                my.Add(1);
                my.Add(2);
                my.Add(3);
                my.Add(4);
                my.Add(5);

                Console.WriteLine(my.Find(7));

                var my2 = new Mycollection<double>();

                my2.Add(123.41);
                my2.Add(1234);
                my2.Add(124);
                my2.Add(123.41);


                Console.WriteLine(my2.Find(123.41));

                var ch = new Mycollection<char>();
                ch.Add('S');
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





            ///////////////////////zd3
            List<char> mycal = new List<char> { 'e', 'f', 'b', 'a', 'c','c','d','h' };
            Console.WriteLine(string.Join(",", mycal.OrderBy(c => c).Distinct()));

Console.WriteLine(string.Join(",",mycal.OrderBy(c=>c).Distinct().Take(3).Concat(mycal.Skip(mycal.Count - 2))));
           // Console.WriteLine(string.Join(",", mycal.Take(3).Concat(mycal.Skip(mycal.Count - 2))));


            ////////////////////////////////////zd4
            News newa = new News();
            Sub chel = new Sub();
            newa.post += new Wow(chel.Read);
            newa.WrightNews();

        }
    }
}
