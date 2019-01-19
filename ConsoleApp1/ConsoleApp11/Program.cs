using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    delegate void Process(string str);

    class Program
    {
        static void Run(string s, string m)
        {
            Console.WriteLine($"{s}走ります。");
        }

        static void Main(string[] args)
        {
            Process p = Run;
            p("ちょこちょこ");

            Console.ReadKey();
        }
    }
}
