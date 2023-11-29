using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
   public class TelephoneExchange:ITelephoneExchange
    {
        public readonly string title;
        public Admin Administrator { get; set; }
        List<Subscriber> SubsribersList = new List<Subscriber>();
       // public VirtNum virtnum;
        public TelephoneExchange(string title, string AdminName)
        {
            this.title = title;
            Administrator = Admin.getInstance(AdminName);
        }

        public void AddSubscriber(Subscriber subscriber) 
        {
            SubsribersList.Add(subscriber);
        }
        public void GetSubscribers()
        {
            Console.WriteLine($"Станция {title}, администратор {Administrator.Name}\nПодкючённые абоненты:");
            if (SubsribersList != null)
                foreach (Subscriber subscriber in SubsribersList)
                    Console.WriteLine($"{subscriber.ToString()}");
            else
                Console.WriteLine("Нет абонентов");
        }

        public ITelephoneExchange Clone()
        {
            return new TelephoneExchange(this.title, this.Administrator.Name);
        }
    }
}
