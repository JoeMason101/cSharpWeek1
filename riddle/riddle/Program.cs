
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            //use a while loop
            //prompt the user and get the answer
            Console.Write("I've got a riddle for you.  ");

            Console.WriteLine("Why did the chicken cross the road?");
            response = (Console.ReadLine()).ToLower();
            //response = response.ToLower();
            Console.WriteLine(response);

            //check the answer using a while loop until a valid answer is given
            while ((response != "to get to the other side") && (response != "i give up"))
            {
                Console.Write("Try again or say 'I give up'");
                Console.WriteLine("Why did the chicken cross the road?");
                response = Console.ReadLine();
                response = response.ToLower();
            }

            //give the user feedback
            if (response == "to get to the other side")
            {
                Console.WriteLine("Yea! You got it right!");
            }
            else
            {
                Console.WriteLine("The answer is: 'To get to the other side'.");
            }

            

            //use a do while loop
            //prompt the user
            Console.Write("I've got another riddle for you.  ");

            //prompt the user check the answer using a while loop until a valid answer is given
            do
            {
                Console.WriteLine("What's yellow and dangerous?");
                response = (Console.ReadLine()).ToLower();
            }
            while ((response != "shark-infested custard") && (response != "i give up"));

            //give the user feedback
            if (response == "shark-infested custard")
            {
                Console.WriteLine("Yea! You got it right!");
            }
            else
            {
                Console.WriteLine("The answer is: 'Shark-infested custard'.");
            }

            //keep the console window open until there's an extra keypress
            Console.ReadKey();

        }
    }
}


