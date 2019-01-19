using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("山田", "太郎");
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            //return $"Person: {this.LastName}{this.FirstName}";
            return base.ToString();
        }
    }
}
