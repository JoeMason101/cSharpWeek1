using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string userI;
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            //for(int i = 0; i<sevenDwarves.Length; i++)
            //{
            //    Console.WriteLine(sevenDwarves[i] + " Your dinner is ready");
            //}

            //foreach(string j in sevenDwarves)
            //{
            //    Console.WriteLine("Heres a nice warm drink " + j);
            //}


         
          

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(sevenDwarves[i] + "What would you like to eat/drink? " );
                userI = Console.ReadLine();
                Console.WriteLine(sevenDwarves[i] + " would like to eat" + userI);
              
            }
        }
    }
}
