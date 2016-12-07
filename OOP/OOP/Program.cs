using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person joe = new Person();
            joe.FirstName = "Joseph"; // call a setter method
            joe.LastName = "Mason";
            joe.BirthDate = new DateTime(1997, 9, 6);
            int result = joe.getAge();
            Console.WriteLine(result);
            joe.sleep();

            joe.wakeUp();
            Console.WriteLine(joe.talk());

            Person david = new Person("David", "B", new DateTime(1973, 1, 1));

            Car honda = new Car();
            honda.Make = "Honda";
            honda.Model = "Civic Coupe";
            honda.Price = 10000;
            //static field
            Car.numberOfCars = 10;
            honda.Accelerate(10);
            Console.WriteLine(honda.Speed);
        }
    }
}
