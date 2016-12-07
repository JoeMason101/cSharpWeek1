using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    //derived from superclass 'person'
    class Employee : Person
    {
        public string Position { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {

        }
        public Employee(string fn, string ln, DateTime bd, string pos, DateTime hd)
            : base(fn,ln,bd)
        {
            this.Position = pos;
            this.HireDate = hd;
        }

        public override string talk()
        {
            return string.Format("Employee {0} says heelo! ", this.FirstName);
        }
    }

    //constructors
    
}
