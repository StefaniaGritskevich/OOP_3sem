using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolnaya
{
    public delegate void Wow();
    public class News
    {
        public event Wow post;
        public void WrightNews()
        {
            if (post != null)
                post();
        }
    }

    public class Sub
    {

        public void Read()
        {
            Console.WriteLine("Читаю новость!");
        }
    }
}
