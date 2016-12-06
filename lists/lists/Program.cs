using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deleteC = false;
            string result;
            string extraResult;
            List<string> books = new List<string>() { "The hunger games", "Harry Potter", "Deathly Hallows", "Horrid Henry" };


            do
            {
                Console.WriteLine("Here is your book collection press A to Add  a book, D to delete, L to list S to Sort, Press E to exit");
                result = Console.ReadLine().ToLower();
                switch (result)
                {
                    case "a":
                        Console.WriteLine("Please enter the book name you would like to add");
                        extraResult = Console.ReadLine();
                        books.Add(extraResult);
                        break;
                    case "d":
                        Console.WriteLine("Please enter the book name you would like to delete");
                        extraResult = Console.ReadLine();
                       deleteC = books.Remove(extraResult);
                        if(deleteC == false)
                        {
                            Console.WriteLine("There is no such book");
                        }
                        break;
                    case "l":
                        foreach(string search in books)
                        {
                            Console.WriteLine(search);
                        }
                        break;
                    case "s":
                        books.Sort();
                        foreach (string search in books)
                        {
                            Console.WriteLine(search);
                        }
                        break;
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Please enter a proper value");
                        break;
                    

                }
            }
            while (result != "e" );




            //foreach(string search in books)
            //{
            //    Console.WriteLine(search);
            //}

        }
    }
}
