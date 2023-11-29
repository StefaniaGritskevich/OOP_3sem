using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
     public interface Interface1<T>
    {
        void Add(T item);
        bool Contains(T item);
        void Remove(T item);
     
    }
}
