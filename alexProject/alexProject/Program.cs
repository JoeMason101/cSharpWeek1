using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a = b;

            Person p = new Person();
            Person p2 = new Person();

            //boxing (Value -> Ref) - wrapper
            object obj1 = a;

            //unboxing (Ref -> Value)
            int result = (int)obj1;

            //accept reference type
            List<Person> people = new List<Person>();

            Dictionary<int, Person> awesomePeople = new Dictionary<int, Person>();
            Person james = new Person();
            james.firstNames = "James";
            james.lastNames = "Long";
            awesomePeople.Add(1, james);
            int count = awesomePeople.Count;

            Person john = new Person();
            Person result2;
            Console.WriteLine(awesomePeople.ContainsKey(1));
            Console.WriteLine(awesomePeople.ContainsValue(john));
            Console.WriteLine(awesomePeople.TryGetValue(1, out result2));
            Console.WriteLine(result2);
        }

        class Person
        {
            public string firstNames;
            public string lastNames;

            public override string ToString()
            {
                return string.Format("{0} {1}", this.firstNames, this.lastNames);
            }
        }
    }
}