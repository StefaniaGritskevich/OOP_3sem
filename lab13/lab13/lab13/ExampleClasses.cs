using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab13
{
    [Serializable]
    public class Trial
    {
        string goal;
        [XmlElement("Goal")]
        public string Goal
        {
            get { return goal; }
            set { goal = value; }
        }
       
        int time;

        [XmlElement("Time")]
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public Trial()
        {

        }
        public Trial(string goal)
        {
            this.goal = goal;
            var random = new Random();
            time = random.Next(1, 100);
        }
        const string ride = " ";
        ////////////////////////////////////////////////////////////
        public override string ToString()
        {
            Console.WriteLine($"Предмет: {Goal}\nВремя выполнения: {Time}");
            return ride;
        }
        public override bool Equals(object obj)
        {
            if (obj is Trial trial)
                return goal == trial.goal;
            return false;
        }

        public override int GetHashCode() => goal.GetHashCode();
    }

    [Serializable]
    [XmlType("Exam")]
    public class Exam : Trial
    {
        [NonSerialized]
        int grade;
        string deal;
        internal string Deal
        {
            get { return deal; }
            set { deal = value; }
        }

        //[XmlIgnore]
        public int Grade
        {
            get { return grade; }
            set{ grade = value;}
        }

        public Exam() { }
        public Exam(string goal, int number, int time) : base(goal)
        {
            Time = time;
            Grade = number;
        }

        public override string ToString()
        {
            Console.WriteLine($"Предмет: {Goal}");
            Console.WriteLine($"Время: {Time}мин");
            Console.WriteLine($"Оценка: {grade}");
           // Console.WriteLine("------------------------------------------------------------");
            return Deal;
        }

    }
}

