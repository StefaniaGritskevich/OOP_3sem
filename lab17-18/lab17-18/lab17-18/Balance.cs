using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{
    class Balance
    {
        private int money = 10;
        private int days = 15;

        public void Use()
        {
            if(money > 0)
            {
                money--;
                Console.WriteLine("Вы используете интернет. Ваш баланс {0}р", money);
            }
            else
                Console.WriteLine("Пополните баланс! ");
        }
        //сохранение состояния
        public BMemento SaveState()
        {
            Console.WriteLine($"Остановка соединения. Текущие параметры: {money}р, {days} дней использования") ;
            return new BMemento(money, days);
        }

        //восстановление состояния
        public void RestoreState(BMemento memento)
        {
            this.money = memento.Money;
            this.days = memento.Days;
            Console.WriteLine($"Восстановление соединения. Текущие параметры: {money}р, {days} дней использования") ;
        }
    }

    class BMemento
    {
        public int Money { get; private set; }
        public int Days { get; private set; }

        public  BMemento(int money, int days)
        {
           this. Money = money;
           this. Days = days;
        }
    }

    //Caretaker
    class History
    {
        public Stack<BMemento> history { get; private set; }
        public History()
        {
            history = new Stack<BMemento>();
        }
    }
}
