using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number between 1 to 10:");
            while (true)
            {
   
                try
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 10)
                        throw new Exception ("Number must be between 1 and 10");

                    Console.WriteLine("Your number is: " + userInput);
                    break;
                } catch (FormatException )
                {
                    Console.WriteLine("Not an int! Please try again!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Value to large");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}
