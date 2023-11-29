﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal sealed class Question : FinalExam
    {
        string question;
        internal string QuestionName
        {
            get { return question; }
            set
            {
                if (value == null)
                    throw new QuestionException("Вызвано исключение: попытка присовить значение null.");
                else
                    question = value;

            }
        }
        string answer;

        internal string Answer
        {
            get { return answer; }
            set
            {
                if (value == null)
                    throw new QuestionException("Вызвано исключение: попытка присовить значение null.");
                else
                    answer = value;

            }
        }
        internal Question(string goal, string str1, string str2, int number,bool admission, int time) : base(goal, number, admission,time)
        {
            QuestionName = str1;
            Answer = str2;
        }

        public override string ToString()
        {
            Console.WriteLine($"Цель: {Goal}");
            Console.WriteLine($"Вопрос: {question}");
            Console.WriteLine($"Ответ: {answer}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine("------------------------------------------------------------");
            return answer;
        }
    }
}
