using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все доступные номера: ");
            PhoneDirectory phoneBook = new PhoneDirectory();

            phoneBook.AddNumber( "33-66-43-77-4");
            phoneBook.AddNumber( "44-99-88-99-0");
            phoneBook.AddNumber( "33-29-58-49-9");
            phoneBook.PrintDirectory();

            Service SMS = new SMS();
            Service VideoCall = new VideoCall();
            TelephoneExchange telephoneExchange = new TelephoneExchange("Velcom", "Петя");
            Subscriber subsriber3G = new Subscriber(new Factory3G(), 476);
            telephoneExchange.AddSubscriber(subsriber3G);
            subsriber3G.AddService(SMS);
            subsriber3G.AddService(SMS);
            subsriber3G.UseService();
     
            Subscriber subsriber4G = new Subscriber(new Factory4G(), 798);
            telephoneExchange.AddSubscriber(subsriber4G);
            subsriber4G.AddService(VideoCall);
            VideoCall = new HighCuolity(VideoCall);
            subsriber4G.AddService(VideoCall);
            subsriber4G.UseService();

            telephoneExchange.GetSubscribers();


            ITelephoneExchange TelephoneExchange2 = new TelephoneExchange("MTC", "Петя");
            ITelephoneExchange clonedTelephoneExchange2 = TelephoneExchange2.Clone();
          clonedTelephoneExchange2.GetSubscribers();


            Console.WriteLine("--------------------------------------------------\n");
            Conecter conecter = new Conecter();
            Conection baseChanal = new Conection();
            conecter.Svyaz(baseChanal);
            //произошла ошибка
            AChanel aChanel = new AChanel();
            //используем адаптер
            IConection aChanal = new ChanalToAnother(aChanel);
            conecter.Svyaz(aChanal);
            Console.WriteLine("------------------------------------------------\n");
            Bill auto = new Bill(4,new Cash());
            auto.Pay();
            auto.Payble = new Credit();
            auto.Pay();
            Console.WriteLine("------------------------------------------------\n");
            Admin admin = new Admin();
            Block block = new Block();
           admin.SetCommand(new BlockOnCommand(block));
            //admin.PressP();
            admin.PressN();
            Console.WriteLine("------------------------------------------------\n");
            Balance balance = new Balance();
            balance.Use();//начинаем использовать интернет, тратим деньги, остолось 9 денег
            History story = new History();
            story.history.Push(balance.SaveState());//сохраняем сведения
            balance.RestoreState(story.history.Pop());
            balance.Use();

        }
    }
}
