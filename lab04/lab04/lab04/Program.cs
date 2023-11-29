using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4_NET;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_4_NET
{
    internal class MainClass
    {
        static void Main()
        {

            Test test2 = new Test("Механика", 78, true);
             test2.Print();
             test2.DoSomething();
             ITrial itrialtest = test2;
           itrialtest.DoSomething();
            Console.WriteLine("------------------------------------------------------------");
            
            Trial triall = new Test("Физика", 39,true);
            triall.Print();
            triall.DoSomething();
            ITrial itrialest2 = (ITrial)triall;
           itrialest2.DoSomething();
            Console.WriteLine("------------------------------------------------------------");
            object person1 = new Test("Математика", 85,true);
            Test mathtest = (Test)person1;
            mathtest.Print();
            mathtest.DoSomething();
            ITrial Imathtest = mathtest;
            Imathtest.DoSomething();
            Console.WriteLine("------------------------------------------------------------");

            Test test123 = new Test("Английский", 84,true);
            Trial triallll = test123;
            triallll.Print();//В данном случае переменной triallll, которая представляет тип Trial, присваивается ссылка на объект Test.
            triallll.DoSomething();
            ITrial Itrialest44 = (ITrial)triallll;
            Itrialest44.DoSomething();
            Console.WriteLine("------------------------------------------------------------");

            FinalExam fexam1 = new FinalExam("КПО", 7, true, 67);
            fexam1.Print();
            fexam1.DoSomething();
            Console.WriteLine("------------------------------------------------------------");

            FinalExam fexam2 = new FinalExam("OOП", 3, false, 45);
            fexam2.Print();
            fexam2.DoSomething();
            Console.WriteLine("------------------------------------------------------------");



            Test test1123 = new Test("ОАИП", 1,true);
            ITrial trial1132 = test1123;
            trial1132.Show();

            ITrial itrial575 = new Test("Ядерная физика", 2,true);
            Test test575 = itrial575 as Test;
            if (test575 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                test575.ToString();
            }

            Test test100 = new Test("Охрана труда", 45,true);
            test100.ToString();
  



            Trial[] allClasses = new Trial[4];
            allClasses[0] = new Test("Проверка на знания printer", 5,true);
            allClasses[1] = new Exam("Экзамен в printer", 1, 9);
            allClasses[2] = new FinalExam("Финальный экзамен printer", 10, false, 45);
            allClasses[3] = new Question("Вопрос для printer", "2 + 2?", "4", 2, false, 87);

            Console.WriteLine("-----------------------------------");

            Printer printer = new Printer();
            printer.IAmPrinting(allClasses[0]);
            printer.IAmPrinting(allClasses[1]);
            printer.IAmPrinting(allClasses[2]);
            printer.IAmPrinting(allClasses[3]);

        }
    }
}


