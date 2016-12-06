using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorH
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] {
    1,
    2,
    3
   };

            try
            {
            for(int i = 0; i <=numbersArray.Length; i++)
                {
                    Console.WriteLine("The next number is is:" + numbersArray[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Whoops it looks like your array is out of bounds!");
            }
            finally
            {
                Console.WriteLine("Tbc!");
            }
        }
    }
}