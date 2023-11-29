using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal partial class FinalExam : Exam
    {
        bool admission;

        internal bool Admission
        {
            get { return admission; }
            set { admission = value; }
        }

        internal FinalExam(string goal, int number, bool admission, int time) : base(goal, number, time)
        {
            Admission = admission;

        }

      


    }
}
