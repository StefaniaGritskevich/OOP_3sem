using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    public interface ITelephoneExchange:IPrototype<ITelephoneExchange>
    {
        void GetSubscribers();
     
    }

    public interface IPrototype<T>
    {
        T Clone();
    }
}
