using StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         group b
            //         by new
            //         {
            //             PublishYear = b.Published.Year,
            //             PublishMonth = b.Published.Month
            //         } into pubs
            //         orderby pubs.Key.ToString()
            //         select pubs;

            var bs = AppTables.Books.GroupBy(b => new
                     {
                        PublishYear = b.Published.Year,
                        PublishMonth = b.Published.Month
                     })
                    .OrderBy(pubs => pubs.Key.ToString());

            //Console.WriteLine(bs);
            foreach (var b in bs)
            {
                Console.WriteLine($" [{ b.Key.PublishYear } - {b.Key.PublishMonth}月] ");
                foreach (var t in b)
                {
                    Console.WriteLine(t.Title);
                }
            }

            Console.ReadKey();
        }
    }
}
