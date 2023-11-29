using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    interface IConection
    {
        void MakeConect();
    }
    class Conection:IConection
    {
        public void MakeConect()
        {
            Console.WriteLine("Установка соединения........");
        }
    }
    class Conecter
    {
        public void Svyaz(IConection conection)
        {
            conection.MakeConect();
        }

    }
    interface IAnother {
        void AnotherChanal();
    }

     public class AChanel:IAnother
    {
        public void AnotherChanal()
        {
            Console.WriteLine("Соединение превано, используется другой канал, ожидайте......");
        }
    }
    public class ChanalToAnother:IConection
    {
        AChanel newChanal;
        public ChanalToAnother(AChanel NewChanal)
        {
            newChanal = NewChanal;
        }
        public void MakeConect()
        {
            newChanal.AnotherChanal();
        } 
    }

}
