/*using System;

namespace lab001
{
    class zd2
    {
        static void Main(string[] args)
        {
            // явное расширяющее преобразование от типа с меньшей разрядностью к типу с большей
            byte a = 4;
            short b = a;
            Console.WriteLine($"byte -> short\na = {a}, b = {b}");
            int c = -8;
            double d = c;
            Console.WriteLine($"int -> double\nc = {c}, d = {d}");
            long l = c;
            Console.WriteLine($"int -> long\nc = {c}, l = {l}");
            c = b;
            Console.WriteLine($"short -> int\nc = {c}, b = {b}");
            float f = 3.7F;
            d = f;
            Console.WriteLine($"float -> double\nf = {f}, d = {d}");
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //явное преобразование 
            int n = Convert.ToInt32("23");
            bool z = true;
            double x = Convert.ToDouble(z);
            int one = 1;
            bool flag = Convert.ToBoolean(one);
            char ch = Convert.ToChar(one);
            Console.WriteLine($"n={n}  d={x}, flag={flag}, ch={ch}");

            Console.WriteLine("-----------------------------------------------------------------\n ");
            //работа с неявно типизированной переменной
            double www = a + b;
            Console.WriteLine(www);
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //упаковка и распаковка 
            int i = 123;
            object o = i;
            int j = (int)o;
            Console.WriteLine(j);
            Console.WriteLine("-----------------------------------------------------------------\n ");
            //nullable переменная
            int? number1 = null;
            Nullable<int> number2 = null;
            Console.WriteLine($"number2={number2}, number1={number1}");
            Console.WriteLine("-----------------------------------------------------------------\n ");
           var myVar = 10; // myVar будет иметь тип int
           //myVar = "Hello"; // Это вызовет ошибку компиляции, так как тип уже определён как int

        }

    }
}
*/