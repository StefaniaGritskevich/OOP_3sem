using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    public abstract class Service
    {
        public double total { get; set; }
        public Service(double sum)
        {
            total = sum;
        }

        public abstract string DoService(double amount);
    }

    public class VideoCall : Service
    {
        public VideoCall() : base(0) { }

        public override string DoService( double amount)
        {
            Console.WriteLine("Вы совершили видео-звонок");
            
            total += amount;
            Console.WriteLine($"Текущий счёт {total}$");
            return "\n";
        }
    }

    public class SMS: Service
    {
        public SMS() : base(0) { }
        public override string DoService(double amount)
        {
            Console.WriteLine("Вы отправили смс");
            total += amount;
            Console.WriteLine($"Текущий счёт {total}$");
            return "\n";
        }
    }

    abstract class ServiceDecorator: Service
    {
        protected Service service;
        public ServiceDecorator(double sum, Service service) : base(0) {
            this.service = service;
        }
    }

    class HighCuolity : ServiceDecorator
    {
        public HighCuolity(Service p) : base(p.total + 15, p) { }
        public override string DoService(double amount)
        {
            Console.WriteLine("Звонок высокого качества, взымается доп. плата");
            return service.DoService(8);
        }
    }

}
