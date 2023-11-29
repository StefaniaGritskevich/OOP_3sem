using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal class Test : Trial, ITrial
    {
        private int score;
        int rightQ;
        const int questions = 150;
        bool form;
        internal bool Form
        {
            get { return form; }
            set
            {
                if(value == true)
                {
                    Console.WriteLine("Тестовая\n");
                }
                else
                    Console.WriteLine("Не тестовая\n");
            }
        }
        internal int RightQ
        {
            get { return rightQ; }
            set
            {
                if (value < 20)
                    throw new ExamException("У вас меньше 20% правильных ответов, вы не аттестованы", value);
                else
                    rightQ = value;

            }
        }
        internal Test(string goal, int number,bool foorm) : base(goal)
        {
            rightQ = number;
            form = foorm;
        }
        internal override bool DoSomething()
        {
            double percentage = (double)RightQ / questions * 100;
            Console.WriteLine($"Оценка: {percentage}%");

            return true;
        }
       bool ITrial.DoSomething()
{
    double percentage = (double)RightQ;

    if (percentage >= 90)
        score = 10;
    else if (percentage >= 80)
        score = 9;
    else if (percentage >= 70)
        score = 8;
    else if (percentage >= 60)
        score = 7;
    else if (percentage >= 50)
        score = 6;
    else if (percentage >= 40)
        score = 5;
    else if (percentage >= 30)
        score = 4;
    else if (percentage >= 20)
        score = 3;
    else
        score = 2;
    Console.WriteLine($"Оценка в баллах: {score}");

    return true;
}


        void ITrial.Show()
        {
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Кол-во правильных ответов: {RightQ}");
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Форма проведения: {(Form ? "тестовая" : "не тестовая")}");
        }

        internal void Show()
        {
            Console.WriteLine($"Кол-во правильных ответов: {RightQ}");
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Форма проведения: {(Form ? "тестовая" : "не тестовая")}");
        }

        public override string ToString()
        {
            Console.WriteLine($"Предмет: {Goal}\nКол-во правильных ответов: {rightQ}\nВремя: {Time}мин");
            return Goal;
        }
        internal override void Print()
        {
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Форма проведения: {(Form ? "тестовая" : "не тестовая")}");
            Console.WriteLine($"Время: {Time}мин");
 
        }
    }
}

