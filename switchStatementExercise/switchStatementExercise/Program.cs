using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String response;

            Console.WriteLine("Please Vote for your president out of the 7 following, Joseph Mason, James Long, Ben Harding, Georgia Mason, Keith Webb, Mark Grimley, Max Gridley");
            response = Console.ReadLine();

            string fullNameJoe = response;
            var names = fullNameJoe.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            Console.WriteLine(lastName);
            if (response.Equals(fullNameJoe) || response.Equals(firstName) || response.Equals(lastName))
            {
                Console.WriteLine("You have voted for " + fullNameJoe);
                Console.WriteLine(fullNameJoe);

            }
            else if (fullNameJoe.Length > 1)
            {

                Console.WriteLine("You need a last name");
            }
            else
            {
                Console.WriteLine("Please enter a first name and last name");
            }

        }
    }
}
            //string fullNameJames = "James Long";
            //var names1 = fullNameJames.Split(' ');
            //string firstName1 = names[0];
            //string lastName1 = names[1];

            //string fullNameBen = "Ben Harding";
            //var names2 = fullNameBen.Split(' ');
            //string firstName2 = names[0];
            //string lastName2= names[1];

            //string fullNameGeo = "Georgia Mason-Webb";
            //var names3 = fullNameGeo.Split(' ');
            //string firstName3 = names[0];
            //string lastName3 = names[1];

            //string fullNameKeith = "Keith Webb";
            //var names4 = fullNameKeith.Split(' ');
            //string firstName4 = names[0];
            //string lastName4 = names[1];

            //string fullNameMark = "Mark Grimley";
            //var names5 = fullNameMark.Split(' ');
            //string firstName5 = names[0];
            //string lastName5 = names[1];

            //string fullNameMax = "Max Gridley";
            //var names6 = fullNameMax.Split(' ');
            //string firstName6 = names[0];
            //string lastName6 = names[1];





            //string reply;
            //switch (response) {

            //    case "Joseph":
            //    case "Mason":
            //    case "Jospeh Mason":
            //        reply = ("You have voted for Joseph Mason");
            //        Console.WriteLine(reply);
            //        break;
            //    case "James":
            //    case "Long":
            //    case "James Long":
            //        reply = ("You have voted for James Long");
            //        Console.WriteLine(reply);
            //        break;
            //    case "Ben":
            //    case "Harding":
            //    case "Ben  Harding":
            //        reply = ("You have voted for Ben Harding");
            //        Console.WriteLine(reply);
            //        break;
            //    case "Georgia":
            //    case "Mason-Webb":
            //    case "Georgia Mason-Webb":
            //        reply = ("You have voted for Georgia Mason-Webb ");
            //        Console.WriteLine(reply);
            //        break;
            //    case "Keith":
            //    case "Webb":
            //    case "Keith Webb":
            //        reply = ("You have voted for Keith Webb");
            //        Console.WriteLine(reply);
            //        break;
            //    case "Mark":
            //    case "Grimley":
            //    case "Mark Grimley":
            //        reply = ("You have voted for Mark Grimley ");
            //        Console.WriteLine(reply);
            //        break;
            //    case "Max":
            //    case "Gridley":
            //    case "Max Gridley":
            //        reply = ("You have voted for Max Gridley");
            //        Console.WriteLine(reply);
            //        break;
            //}

//        }

//    }
//}
