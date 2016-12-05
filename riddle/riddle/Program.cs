using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "your name";
            string userAnswer = "";
            string toSmall = "";
            string continues = "";
            //while(toSmall != answer)
            //{

            //    Console.WriteLine("What belongs to you but others use it more than you do?");
            //    userAnswer = Console.ReadLine();
            //   toSmall = userAnswer.ToLower();
            //    Console.WriteLine(userAnswer);
            //}
         
            do
            {
                Console.WriteLine("What belongs to you but others use it more");
                userAnswer = Console.ReadLine();
                toSmall = userAnswer.ToLower();


      }
            while (toSmall != answer);
           Console.WriteLine("YOu got it!");            


        }
    }
}
