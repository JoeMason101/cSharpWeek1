using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    //subclass of object class
    // Employeee is a person. Since person is an Object. Employee is an object
    class Person
    {
        //attributes
        public string FirstName { get; set; } //fields
        public string LastName { get; set; } //automatedproperties
        public DateTime BirthDate { get; set; }
        private Boolean isSleeping;
        //behaviours

        public Person()
        {

        }

        public Person(string fn)
        {
            this.FirstName = fn;
        }
        
        public Person(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        public Person(string fn, string ln, DateTime dt)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.BirthDate = dt;
        }

        //methods
        public int getAge()
        {
            if (BirthDate == null)
                return 0;

            return (DateTime.Now.Subtract(BirthDate).Days / 365);
        }

        public virtual string talk()
        {
            if(isSleeping)
            {
                throw new Exception(string.Format("{0} is sleeping", FirstName));
            }

            return string.Format("{0} {1} Says im awake", FirstName, LastName);
        }

        public void sleep()
        {
            this.isSleeping = true;
        }

        public void wakeUp()
        {
            if(isSleeping)
            {
                isSleeping = false;
            }
        }
    }




}

