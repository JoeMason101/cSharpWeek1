using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book hp = new Book("Harry Potter", "Fantasy","JK",244,15,"19919AS",8);
            Console.WriteLine(hp.currentPage);
            hp.nextPage();
            Console.WriteLine(hp.currentPage);
        }
    }
}
