using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    //class -> reference type, struct -> value type
    public struct Book

    {
        public string title;
        public string category;
        public string author;
        public int numPage;
        public int currentPage;
        public string ISBN;
        public int price;

        //constructor is method to instantiate fields(attributes)
        public Book(string title, string category, string author, int numPage, int currentPage, string ISBN, int price)
        {
            this.title = title;
            this.category = category;
            this.author = author;
            this.numPage = numPage;
            if (currentPage <= numPage)
                this.currentPage = currentPage;
            else
                throw new Exception("Not Acceptable!");

            this.ISBN = ISBN;
            this.price = price;


        }
        //method nextPage
        public void nextPage()
        {
            if (currentPage != numPage)

            {
                currentPage++;
                Console.WriteLine("Current page is now" + this.currentPage);
            }

            else
                Console.WriteLine("Reach end of book!");
        }

        //method prevPAge
        public void prevPage()

        {
            if (currentPage != 1)
            {
                currentPage--;
                Console.WriteLine("current page is now " + this.currentPage);
            }
            else
                Console.WriteLine("At the beginning of the book");
        }

    }


}