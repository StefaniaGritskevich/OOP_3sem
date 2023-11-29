using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    public abstract class SubscriberFactory 
    {
        public abstract string CreatService();
    }

    public class Factory3G : SubscriberFactory
    {
        public override string CreatService()
        {
            return "3G";
        }
    }
    public class Factory4G : SubscriberFactory
    {
        public override string CreatService()
        {
            return "4G";
        }
    }

    public class Subscriber
    {
        List<Service> services = new List<Service>();
        private int id;
        private Bill bill;
        private string type;

        public Subscriber(SubscriberFactory factory, int Id)
        {
            bill = new Bill(2, new Cash());
            bill.summ = 0;
            id = Id;
            type = factory.CreatService();
        }

        public void AddService(Service service)
        {
            services.Add(service);
            bill.summ += service.total; 
        }

        public double GetBill()
        {
            return bill.summ;
        }

        public void UseService()
        {
            Console.WriteLine($"Абонент #{id}, типа {type} на связи");
            if(services != null)
            {
                foreach (Service service in services)
                    service.DoService(0.5);
                
            }
            else
            {
                Console.WriteLine("услуги не подключены");
            }
        }
        public override string ToString()
        {
          
            Console.WriteLine($"Абонент#{id}");
            return type;
        }

    }


}
