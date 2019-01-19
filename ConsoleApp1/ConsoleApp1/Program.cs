using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyPartial
            {
                FirstName = "太郎",
                LastName = "山田"
            };

            Console.WriteLine(mc.Show());
            Console.WriteLine(mc.Greet());
            Console.ReadKey();
        }
    }

    partial class MyPartial
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }


}
