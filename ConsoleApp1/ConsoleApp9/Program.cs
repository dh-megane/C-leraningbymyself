using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = (Coordinate)(10);
            Console.WriteLine($"({c.X}, {c.Y})");
            Console.ReadKey();
        }
    }

    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator Coordinate(int num)
        {
            return new Coordinate()
            {
                X = num,
                Y = num
            };
        }
    }
}
