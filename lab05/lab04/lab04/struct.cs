using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_NET
{
    
    public struct Name
    {
        public string? name;
        public  int? kab;
        public Name(string name, int kab)
        {
            this.name = name;
            this.kab = kab;
        }
        public void Print()
        {
            Console.WriteLine($"ФИО преподавателя: {name}\nКабинет №{kab}");
        }
    }
   
}
