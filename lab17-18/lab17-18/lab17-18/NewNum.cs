using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_18
{

    public class PhoneDirectory
    {
        private List<Number> directory;

        public PhoneDirectory()
        {
            directory = new List<Number>();
        }

        public void AddNumber( string userNum)
        {
            var newNum = new NumBuilder()
                .SetCode()
                .SetNum(userNum)
                .Build();

            directory.Add(newNum);
        }

        public void PrintDirectory()
        {
            foreach (var number in directory)
            {
              
                Console.WriteLine("Код: " + number.Code);
                Console.WriteLine("Номер: " + number.UserNum);
                Console.WriteLine();
            }
        }
    }
    public class Number
    {

        public string Code { get; set; }
        public string UserNum { get; set; }
        public Number(string code, string userNum)
        {
            Code = code;
            UserNum = userNum;
        }

       
    }

    public interface INumBuilder
    {
        INumBuilder SetNum(string userNum);
        INumBuilder SetCode();
        Number Build();
    }
    internal class NumBuilder : INumBuilder
    {

        private string _userNum;
        private string _code;
        public INumBuilder SetNum(string userNum)
        {
            _userNum = userNum;
            return this;
        }

        public INumBuilder SetCode()
        {
            _code = "+375";
            return this;
        }

        public Number Build()
        {
            return new Number(_code, _userNum);
        }

       
    }
}