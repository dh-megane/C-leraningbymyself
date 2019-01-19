using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    delegate void OutputProcess(string str);

    class Program
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach(var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            Console.WriteLine($" [{data}] ");
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new Program();
            //OutputProcess proc = AddQuote;
            du.ArrayWalk(data, AddQuote);
            Console.ReadKey();
        }
    }
}
