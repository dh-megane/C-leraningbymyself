using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Coordinate { X = 10, Y = 20 };
            c1 += 7;
            Console.WriteLine(c1.X);
            Console.WriteLine(c1.Y);
            Console.ReadKey();
        }
    }

    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate()
            {
                X = c1.X + c2.X,
                Y = c1.Y + c2.Y
            };
        }

        public static Coordinate operator +(Coordinate c1, int x)
        {
            return new Coordinate()
            {
                X = c1.X + x,
                Y = c1.Y
            };
        }
    }
}
