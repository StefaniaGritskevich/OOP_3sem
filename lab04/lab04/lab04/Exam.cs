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
        internal int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ExamException("Оценка должна быть от 0 до 10", value);
                else
                    grade = value;

            }
        }
       
        internal Exam(string goal, int number, int time) : base(goal)
        {
            Time = time;
            Grade = number;
        }

        internal override bool DoSomething()
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
