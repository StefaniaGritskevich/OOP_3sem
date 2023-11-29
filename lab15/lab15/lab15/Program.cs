using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TPL1.Task1(1000);
                TPL1.Task2(100);
                TPL3_4.Task4_1();
                TPL3_4.Task4_2();
                TPL5.Task5();
                TPL5.Task6();
                TPL5.Task7();
                TPL8.Task8();
       
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
