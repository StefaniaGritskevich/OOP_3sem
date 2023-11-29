using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal class Exam : Trial
    {
        int grade;
        int numberOfQuestions;
        internal int Grade
        {
            get { return grade; }
            set
            {
                    grade = value;

            }
        }
        internal int NumberOfQuestions
        {
            get { return numberOfQuestions; }
            set { numberOfQuestions = value; }
        }
        internal Exam(string goal, int number, int time) : base(goal)
        {
            Time = time;
            if(time < 60 || time > 120)
            {
                throw new TimeEx("Error 2: Недопустимое время", time);
            }
           Grade = number;
            if(number < 0 || number> 10)
            {
                throw new MyExceptionGrade("Error 1: Значение оценки должно быть > 0 и < 10", number);
            } 
            
        }

        internal Exam(EnumOfQ enumOfQ, string goal, int time) : base(goal)
        {
            Time = time;
            Grade = (int)enumOfQ;
            NumberOfQuestions = (int)enumOfQ;
        }

        internal override bool DoSomething(int qv)
        {
            if (Grade > 4)
            {
                Console.WriteLine("Вы переведены на следующий курс");
            }
            else
            {
                Console.WriteLine("Вы отчислены");
            }
            return true;
        }
        internal override void Print()
        {
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Оценка: {grade}");
        }

        public override string ToString()
        {
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Оценка: {grade}");
            Console.WriteLine("------------------------------------------------------------");
            return Goal;
        }

    }
}
