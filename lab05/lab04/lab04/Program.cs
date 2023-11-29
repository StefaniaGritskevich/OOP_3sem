using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Lab_4_NET;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_4_NET
{
    internal class MainClass
    {
        static void Main()
        {
            /*
                        Test test2 = new Test("Механика", 78, true);
                        test2.Print();
                        test2.DoSomething();
                        ITrial itrialtest = test2;
                        itrialtest.DoSomething();
                        Console.WriteLine("------------------------------------------------------------");

                        Trial triall = new Test("Физика", 39, true);
                        triall.Print();
                        triall.DoSomething();
                        ITrial itrialest2 = (ITrial)triall;
                        itrialest2.DoSomething();
                        Console.WriteLine("------------------------------------------------------------");
                        object person1 = new Test("Математика", 85, true);
                        Test mathtest = (Test)person1;
                        mathtest.Print();
                        mathtest.DoSomething();
                        ITrial Imathtest = mathtest;
                        Imathtest.DoSomething();
                        Console.WriteLine("------------------------------------------------------------");

                        Test test123 = new Test("Английский", 84, true);
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



                        Test test1123 = new Test("ОАИП", 1, true);
                        ITrial trial1132 = test1123;
                        trial1132.Show();

                        ITrial itrial575 = new Test("Ядерная физика", 2, true);
                        Test test575 = itrial575 as Test;
                        if (test575 == null)
                        {
                            Console.WriteLine("Преобразование прошло неудачно");
                        }
                        else
                        {
                            test575.ToString();
                        }

                        Test test100 = new Test("Охрана труда", 45, true);
                        test100.ToString();




                        Trial[] allClasses = new Trial[4];
                        allClasses[0] = new Test("Проверка на знания printer", 5, true);
                        allClasses[1] = new Exam("Экзамен в printer", 1, 9);
                        allClasses[2] = new FinalExam("Финальный экзамен printer", 10, false, 45);
                        allClasses[3] = new Question("Вопрос для printer", "2 + 2?", "4", 2, false, 87);

                        Console.WriteLine("-----------------------------------");

                        Printer printer = new Printer();
                        printer.IAmPrinting(allClasses[0]);
                        printer.IAmPrinting(allClasses[1]);
                        printer.IAmPrinting(allClasses[2]);
                        printer.IAmPrinting(allClasses[3]); */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

          /*  Console.WriteLine("LAB 5\n");
              Session session = new Session();

          // Создаем экзамены и добавляем их в сессию

          Exam kpoExam = new Exam("КПО", 1, 120);
           session.addToSession(kpoExam);
           EnumOfQ now = EnumOfQ.kpo;
           Session.PrintMessage(now);
           Name teaher_name1 = new Name("Иванов Иван Иванович", 102);
           teaher_name1.Print();
           session.showSession(kpoExam);


           Exam mathExam = new Exam("Математика", 10, 100);
           session.addToSession(mathExam);
           EnumOfQ mat = EnumOfQ.math;
           Session.PrintMessage(mat);
           Name teaher_name3 = new Name("Сидоров Александ Иванович", 12);
           teaher_name3.Print();
           session.showSession(mathExam);

           Exam mathExam2 = new Exam("Математика", 4, 100);
           session.addToSession(mathExam);
           Session.PrintMessage(EnumOfQ.math);
           Name teaher_name2 = new Name("Петров Пётр Петрович", 324);
           teaher_name2.Print();
           session.showSession(mathExam);
           Controller controller = new Controller();
           Console.WriteLine($"Кол-во экзаменов математики: {controller.findExam(session, "Математика")}");
           Console.WriteLine($"Кол-во экзаменов: {controller.allExams(session)}");
           Exam exam1 = new Exam(EnumOfQ.kpo, "КПО", 90);
           Exam exam2 = new Exam(EnumOfQ.kpo, "КПО", 120);
           Exam exam3 = new Exam(EnumOfQ.mechanic, "Механика", 150);
           Exam exam4 = new Exam(EnumOfQ.mechanic, "Механика", 15);
           Exam exam5 = new Exam(EnumOfQ.mechanic, "Механика", 10);

           Session session1 = new Session();
           session.addToSession(exam1);
           session.addToSession(exam2);
           session.addToSession(exam3);
           session.addToSession(exam4);
           session.addToSession(exam5);


           EnumOfQ numberOfQuestions = EnumOfQ.kpo;
           int count = session.CountExamsWiQ(numberOfQuestions);


           EnumOfQ numberOfQuestions2 = EnumOfQ.mechanic;
           int count2 = session.CountExamsWiQ(numberOfQuestions2);

           Console.WriteLine($"Количество экзаменов по {numberOfQuestions} с 15 вопросами: {count}");

           Console.WriteLine($"Количество экзаменов по {numberOfQuestions2} с 30 вопросами: {count2}");
*/

            ////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Lab6");


            try
            {
                Exam test1 = new Exam("ООП", -2, 120);
            }
            catch (MyExceptionGrade massage)
            {
                Console.WriteLine(massage);
                Console.WriteLine($"\nНекорректное значение: {massage.Value}\n");
            }

            try
            {
                Exam test2 = new Exam("Русский", 5, 125);
            }
            catch (TimeEx massage)
            {
                Console.WriteLine(massage);
                Console.WriteLine($"\nНекорректное значение: {massage.Value}\n");
            }

            try
            {
                Test test3 = new Test("Физика", 67, true);
                test3.DoSomething(0);
            }
            catch (ZeroEx massage)
            {
                Console.WriteLine(massage);
            }
            try
            {
                Question test4 = new Question("Первый вопрос", "2 + 2 * 2", null, 2, false, 120);
            }
            catch (QException massage)
            {
                Console.WriteLine(massage);
            }
            /////////
            ///
            try
            {
                int x = 5; // DivideByZeroException
                int y = x / 0;
            }
            catch (DivideByZeroException dv)
            {
                Console.WriteLine($"Исключение: {dv.Message}");
                Console.WriteLine($"Source: {dv.Source}");
                Console.WriteLine($"Расположение: {dv.TargetSite}");
                Console.WriteLine($"Трассировка стека: {dv.StackTrace}");

                throw;
            }

            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                object obj = "Beloded";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

            int[] arr = { 1, 2, 3, 4, 5 }; // массив размером 5
            try
            {
                var length = 10;
               Debug.Assert(length == arr.Length, "Check");
                Debugger.Break();
                if (length > arr.Length) throw new IndexOutOfRangeException("эта длина превышает размер массива");
                for (var i = 0; i < length; i++)
                    arr[i] += arr[i];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\n\tError");
                Console.WriteLine($"Сообщение об ошибке: {ex.Message}");
                Console.WriteLine("Расположение: {0}", ex.TargetSite);

                // Внутренний catch блок для IOORE, забрасываем его выше по стеку
             
                try
                {
                    // Дополнительная обработка IOORE.
                    Console.WriteLine("Обработка внутреннего исключения IndexOutOfRangeException");
                    throw ex; // проброс исключения выше по стеку вызовов.
                }
                catch (IndexOutOfRangeException innerEx)
                {
                    Console.WriteLine("Внутреннее исключение: " + innerEx.Message);
                  
                }
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
           





        }



    }
        }



