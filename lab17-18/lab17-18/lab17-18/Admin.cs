using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{

    public interface ICommand
    {
        void Execute();
        void Undo();
    }
    //Receiver - получатель 
    class Block
    {
        public void Normal()
        {
            Console.WriteLine("Пользователь подключен к сети!");
        }
        public void Blocked()
        {
            Console.WriteLine("Пользователь заблокирован:(");
        }
    }
    class BlockOnCommand : ICommand
    {
        Block Block;
        public BlockOnCommand(Block block)
        {
            Block = block;
        }

        public void Execute()
        {
            Block.Normal();
        }
        public void Undo()
        {
            Block.Blocked();
        }
    }

    //Invoker - инициатор
    public class Admin
    {
        ICommand Command;
        public static Admin instance;
        public string Name { get; private set; }
        protected Admin(string name)
        {
            this.Name = name;
        }
        public Admin() { }
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public void PressP()
        {
            Command.Execute();
        }
        public void PressN()
        {
            Command.Undo();
        }

        public static Admin getInstance(string name)
        {
            if (instance == null)
                instance = new Admin(name);
            return instance;
        }
    }
}
