using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    internal class Controller
    {

        internal int findExam(Session session, string predmet)
        {
            int kolvo = 0;
            foreach (Exam exammm in session)
            {
                if (exammm.Goal == predmet)
                {
                    kolvo++;
                }
            }
            return kolvo;
        }

        internal int allExams(Session session)
        {
            int kal = 0;
            foreach(Exam exammm in session)
            {
                kal++;
            }
            return kal;
        }

    }
}
