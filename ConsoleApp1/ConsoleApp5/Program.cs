using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("山下", "太郎");
            var person2 = new Person("山下", "太郎");
            var person3 = new Person("掛谷", "康太");
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 != person3);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (Object.ReferenceEquals(p1, p2))
            {
                return true;
            }

            if ((object)p1 == null || (object)p2 == null ||
                    p1.GetType() != p2.GetType())
            {
                return false;
            }

            return p1.FirstName == p2.FirstName && p1.LastName == p2.LastName;
        }

        //public static bool operator !=(Person p1, Person p2)
        //{
        //    return !(p1 == p2);
        //}
    }
}