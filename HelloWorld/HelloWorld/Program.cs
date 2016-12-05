using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //display "Hello World" on the screen
            //Console.WriteLine("Hello,World!");
            int myNum = 5;
            int numStored;
            int numOfGuesses;

            //          Console.WriteLine("Write a number");
            //           numStored = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    numStored = Convert.ToInt32(Console.ReadLine());
            //} while (numStored != myNum);
            //Console.WriteLine("Correct");
            Console.WriteLine("Welcome to my game, how many chances would you like?");
            numOfGuesses = Convert.ToInt32(Console.ReadLine());
            int stored = numOfGuesses;
      
            for (int i =0; i < numOfGuesses; i++)
            {


                Console.WriteLine("Enter a number");
                numStored = Convert.ToInt32(Console.ReadLine());
                if(numStored!= myNum)
                {
                    Console.WriteLine("try again");
                    Console.WriteLine("You have " + --stored + " remaining chances to guess the number");
                }
                else
                {
                    Console.WriteLine("Your number is right!");
                    break;
                }
            }
        }



             
    }
}
