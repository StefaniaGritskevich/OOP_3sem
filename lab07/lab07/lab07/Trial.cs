using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public abstract class Trial
    {
        string goal;
        internal string Goal
        {
            get { return goal; }
            set { goal = value; }
        }

        int time;
        internal int Time
        {
            get { return time; }
            set { time = value; }
        }
        internal Trial(string goal)
        {
            this.goal = goal;
            var random = new Random();
            time = random.Next(1, 100);
        }

        internal abstract bool DoSomething();
        internal abstract void Print();
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
}
