using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{

   public  interface IPay {
        void Pay();
    }

   public  class Cash : IPay
    {
        public void Pay()
        {
            Console.WriteLine("Оплатить счёт в банке наличными.");
        }
    }

    public class Credit: IPay
    {
        public void Pay()
        {
            Console.WriteLine("Оплатить в приложении по карте.");
        }
    }
    public class Bill
    {
        public double summ = 0;
        public IPay Payble { get; set; }
        public Bill(double Sum, IPay paybat)
        {
            summ = Sum;
            Payble = paybat;

        }
        public void Pay()
        {
            Payble.Pay();
        }
    }
}
