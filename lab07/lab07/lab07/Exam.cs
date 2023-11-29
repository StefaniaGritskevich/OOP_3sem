﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Exam : Trial
    {
        int grade;
        internal int Grade
        {
            get { return grade; }
            set
            {
              
                    grade = value;

            }
        }

        internal Exam(string goal, int number, int time) : base(goal)
        {
            Time = time;
            if (time < 60 || time > 120)
            {
                throw new TimeEx("Error 2: Недопустимое время", time);
            }
            Grade = number;
            if (number < 0 || number > 10)
            {
                throw new MyExceptionGrade("Error 1: Значение оценки должно быть > 0 и < 10", number);
            }
        }

        internal override bool DoSomething()
        {
            if (Grade > 4)
            {
                Console.WriteLine($"Ваша оценка {Grade} по {Goal},вы сохранили стипендию");
            }
            else
            {
                Console.WriteLine($"Ваша оценка {Grade} по {Goal},поздавляю, у вас пересдача))))))");
            }
            Console.WriteLine("------------------------------------------------------------");
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
