using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Coordinate() { X = 10, Y = 20 };
            var b = ++a;

            Console.WriteLine($"({a.X},{ a.Y })");
            Console.WriteLine($"({b.X},{ b.Y })");

            var m = new Coordinate() { X = 10, Y = 20 };
            var n = m++;

            Console.WriteLine($"({m.X},{ m.Y })");
            Console.WriteLine($"({n.X},{ n.Y })");

            Console.ReadKey();
        }
    }

    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator ++(Coordinate c)
        {
            c.X++;
            c.Y++;
            return c;
        }
    }
}
