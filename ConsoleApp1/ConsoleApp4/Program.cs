using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("掛谷", "哲夫");
            Console.WriteLine(person1.GetHashCode());

            var d = new Dictionary<Person, int>();
            d.Add(person1, 10);
            person1.LastName = "山田";
            //var person2 = new Person("山下", "太郎");
            //var person3 = new Person("鈴木", "一郎");
            //Console.WriteLine(person1.Equals(person2));
            //Console.WriteLine(person1.Equals(person3));
        
            Console.WriteLine(person1.GetHashCode());
            //Console.WriteLine(person3.GetHashCode());
            Console.ReadKey();
            Console.WriteLine(d[person1]);
            Console.ReadKey();
        }
    }

    class Person : IEquatable<Person>
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool Equals(Person other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            //var p = obj as Person;
            return this.FirstName == other.FirstName && this.LastName == other.LastName;
            
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
