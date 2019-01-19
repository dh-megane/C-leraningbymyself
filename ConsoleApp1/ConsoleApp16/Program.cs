using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(Count);
            var t2 = new Thread(Count);
            var t3 = new Thread(Count);

            //Task t1 = Task.Run(() => Count(1));
            //Task t2 = Task.Run(() => Count(2));
            //Task t3 = Task.Run(() => Count(3));

            //Task.WaitAll(t1, t2, t3);

            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("すべての処理が終了しました。");
            Console.ReadKey();
        }

        static void Count(object n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Task{ n }: { i }");
            }
        }
    }
}
