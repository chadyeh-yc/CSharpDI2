using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacResolveParameter
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        string _Name;
        int _Age;
        public ConsoleMessage(string name, int age)
        {
            _Name = name;
            _Age = age;
        }
        public void Write(string message)
        {
            Console.WriteLine($"[{_Name}, {_Age}] 訊息: {message} 已經寫入到螢幕上了");
        }
    }
}
