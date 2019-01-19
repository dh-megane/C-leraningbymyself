using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Program
    {
        //void ArrayWalk(string[] data, Func<string, string> output)
        //{
        //    foreach (var value in data)
        //    {
        //        Console.WriteLine(output(value));
        //    }
        //}

        void ArrayWalk(string[] data, Action<string> output)
        {
            //foreach (var value in data)
            //{
            //    Console.WriteLine(output(value));
            //}
        }

        void OutputString(Action output) { }

        static void Main(string[] args)
        {
            //var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var cls = new Program();
            Action act = () => Console.WriteLine("こんにちは、世界!");
            act();
            Console.ReadKey();
        }
    }

    class Counter
    {
        public int Result { get; private set; }

        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}
