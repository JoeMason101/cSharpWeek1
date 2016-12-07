using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = 0;
            double numTwo = 0;
            string result;
            bool exit = false;
            Console.WriteLine("Enter number");
            numOne = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter number");
                numTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("+ for addition");
                Console.WriteLine("- for subtraction");
                Console.WriteLine("/ for division");
                Console.WriteLine("* for multiplication");
                Console.WriteLine("Press X to exit");
                result = Console.ReadLine().ToUpper();
               
 
                switch (result)
                {
                    case "+":
                        numOne = (numOne + numTwo);
                        Console.WriteLine(numOne);
                        break;
                    case "-":
                        numOne = (numOne - numTwo);
                        Console.WriteLine(numOne);
                        break;
                    case "/":
                        numOne = (numOne / numTwo);
                        Console.WriteLine(numOne);
                        break;
                    case "*":
                        numOne = (numOne * numTwo);
                        Console.WriteLine(numOne);
                        break;
                    case "X":
                        exit = true;
                        Console.WriteLine("Thank you for using my calculator");
                        break;


                }
            }
            while (exit != true);
        }
    }
}
