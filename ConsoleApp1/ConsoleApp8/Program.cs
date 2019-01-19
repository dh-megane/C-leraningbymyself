using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Coordinate() { X = 10, Y = 20 };
            if(c)
            {
                Console.WriteLine("変数cは真です。");
            }

            Console.ReadKey();
        }
    }

    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Coordinate c)
        {
            return c.X >= 0 && c.Y >= 0;
        }

        public static bool operator false(Coordinate c)
        {
            return c.X < 0 || c.Y < 0;
        }
    }
}
