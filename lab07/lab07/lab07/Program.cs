using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {


            CustomSet<Exam> examSet = new CustomSet<Exam>();
            Exam exam1 = new Exam("Math", 5, 60);
            exam1.DoSomething();
            examSet.Add(exam1);
            Exam exam2 = new Exam("Physics", 2, 90);
            exam2.DoSomething();
            examSet.Add(exam2);
            //CustomSet<int> newset = new CustomSet<int>();
            Exam exam3 = new Exam("KPO", 3, 90);
            exam3.DoSomething();
            examSet.Add(exam3);
            try
            {
                Exam exam4 = new Exam("ded", -3, 90);
                exam4.DoSomething();
                examSet.Add(exam4);
            }

            catch (MyExceptionGrade massage)
            {
                Console.WriteLine(massage);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            try
            {
                Exam exam5 = new Exam("ded", 3, 140);
                exam5.DoSomething();
                examSet.Add(exam5);
            }
            catch (TimeEx massage)
            {
                Console.WriteLine(massage);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            int countfails = examSet.Search();
            Console.WriteLine($"Количество людей не сдавших сессию:{countfails}\n----------------------------------------------------------- ");

            string filePath = "examSet.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(examSet.ToString());
                writer.WriteLine($"Количество людей не сдавших сессию:{countfails} ");
            }
            Console.WriteLine("Информация о множестве записана в файл.");
          


        }
    }
}

