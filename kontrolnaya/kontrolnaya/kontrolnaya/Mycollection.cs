using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolnaya
{
    public class Mycollection<T>:List<T>
    {
        public bool Add(T element)
        {
            if (element is int || element is double)
            {
                base.Add(element);
                return true;
            }
            else
            {
                throw new Exception("Невозможно привести к типу int или double");
            }


        }

        public bool Find(T element)
        {
            return base.Contains(element);
        }


    }
}
