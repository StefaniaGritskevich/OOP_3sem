using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal partial class FinalExam
    {

        public override string ToString()
        {
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Оценка: {Grade}");
            string admissionStatus = admission ? "Допущен к выпускному экзамену" : "Не допущен к выпускному экзамену";
            Console.WriteLine($"Статус допуска: {admissionStatus}");
            Console.WriteLine("------------------------------------------------------------");
            return Goal;
        }

        internal override void Print()
        {
            string admissionStatus = admission ? "Допущен к выпускному экзамену" : "Не допущен к выпускному экзамену";
            Console.WriteLine($"Статус допуска: {admissionStatus}");
        }
    }
}
