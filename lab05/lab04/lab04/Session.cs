using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal class Session
    {
        List<Exam> session = new List<Exam>();
        internal List<Exam> Sessions
        {
            get { return session; }
            set { session = value; }
        }

        public IEnumerator<Exam> GetEnumerator() => session.GetEnumerator(); // для нумерации элементов коллекции Exam
        internal void addToSession(Exam exam)
        {
            session.Add(exam);
        }
        internal void deleteSessionExam(Exam exam)
        {
            session.Remove(exam);
        }

     
        internal static void PrintMessage(EnumOfQ enumOfQ)
        {
            int numberOfQuestions = 0;

            switch (enumOfQ)
            {
                case EnumOfQ.math:
                    numberOfQuestions = (int)EnumOfQ.math;
                    break;
                case EnumOfQ.kpo:
                    numberOfQuestions = (int)EnumOfQ.kpo;
                    break;
                case EnumOfQ.mechanic:
                    numberOfQuestions = (int)EnumOfQ.mechanic;
                    break;
                case EnumOfQ.ded:
                    numberOfQuestions = (int)EnumOfQ.ded;
                    break;
                case EnumOfQ.oop:
                    numberOfQuestions = (int)EnumOfQ.oop;
                    break;
            }

            Console.WriteLine($"Количество вопросов: {numberOfQuestions}");
        }


        internal void showSession(Exam selectedExam)
        {
            if (session.Contains(selectedExam))
            {
                selectedExam.Print();
                Console.WriteLine("|---------------------------------------|");
            }
            else
            {
                Console.WriteLine("Выбранный экзамен не найден в сессии.");
            }
        }

        internal int CountExamsWiQ(EnumOfQ numberOfQuestions)
        {
            int count = session.Count(exam => (int)numberOfQuestions == exam.NumberOfQuestions);
            return count;
        }




    }
}
