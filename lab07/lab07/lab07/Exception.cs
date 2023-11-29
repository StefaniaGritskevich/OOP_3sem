using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab07
{

    public class MyExceptionGrade : System.Exception
    {
        public int Value { get; set; }
        public MyExceptionGrade(string massage, int value) : base(massage)
        {
            this.Value = value;
        }
    }

    public class TimeEx : MyExceptionGrade
    {
        public TimeEx(string massage, int value) : base(massage, value)
        { }
    }

    public class ZeroEx : MyExceptionGrade
    {
        public ZeroEx(string massage, int value) : base(massage, value) { }
    }

    public class QException : System.Exception
    {
        public QException(string massage) : base(massage) { }
    }
}
