using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct s;
            s.Message = "AAA";
            s.Value = 100;
            Console.WriteLine(s.Message + s.Value);
            Console.ReadKey();
        }
    }

    struct MyStruct
    {
        public string Message;
        public int Value;

        public MyStruct(string message, int value)
        {
            this.Message = message;
            this.Value = value;
        }
    }
}
