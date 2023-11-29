using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab15
{
    class TPL3_4
    {
        public static int Sum(params int[] nums) => nums.Sum(); 
        public static double GetSquareOfCyrcle(int radius) => Math.PI * radius * radius;
        public static double GetRadius2(double square) => square / Math.PI;

        public static void Task4_1()
        {
            Console.WriteLine("--------Task4_1-------");
            var task1 = Task.Run(() => Sum(1, 2,3,4,5,6,7,8,9,10));
            var task2 = task1.ContinueWith(n => GetSquareOfCyrcle(n.Result)); // используется для указания задачи, которая должна быть выполнена после завершения предыдущей задачи
            var task3 = task2.ContinueWith(square => GetRadius2(square.Result));

            Console.WriteLine("Результат 4 задания:" + task3.Result);
        }

        public static void Task4_2()
        {
            Console.WriteLine("--------Task4_2-------");
            Task<int> task1 = new(() => Sum(1, 2,3,4,5,6,7,8,9,10));
            task1.Start();
            task1.GetAwaiter().GetResult();//блокировкa выполнения текущего потока до завершения задачи и получение результата
            Task<double> task2 = new(() => GetSquareOfCyrcle(task1.Result));
            task2.Start();
            task2.GetAwaiter().GetResult();
            Task<double> task3 = new(() => GetRadius2(task2.Result));
            task3.Start();
            task3.GetAwaiter().GetResult();
             Console.WriteLine("Результат 4 задания:" + task3.Result);
        }

    }
}
