using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> codingLanguage = new Dictionary<string, int>();
            codingLanguage.Add("Java", 1);
            codingLanguage.Add("Javascript", 2);
            codingLanguage.Add("C#", 3);
            codingLanguage.Add("Python", 4);

            //if(codingLanguage.ContainsKey("Java"))
            //{
            //    int value = codingLanguage["C#"];
            //    Console.WriteLine(value);
            //}

            //foreach (var pair in codingLanguage)
            //{
            //    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            //}

            int count1 = codingLanguage.Count;
            Console.WriteLine("The amount of value key values with pair is " + count1);
            string result;
            string key1;
            int value1;
            int valid = 0;
            do
            {
                Console.WriteLine("Press a to add an entry, R to remove an entry, L for Dictornary List, X to Exit ");            
                result = Console.ReadLine();
              switch(result)
                {
                    case "a":
                        Console.WriteLine("Please enter a key you would like to add");
                        key1 = Console.ReadLine();
                        Console.WriteLine("Please enter a value you would like to add must be integer");
                        value1 = Convert.ToInt32(Console.ReadLine());
                        
                       
                        break;
                    case "r":
                        Console.WriteLine("Please enter a key, so you can remove a dictornary entry");
                        key1 = Console.ReadLine();
                        

                        if(codingLanguage.Remove(key1))
                        {
                            codingLanguage.Remove(key1);
                            Console.WriteLine(key1 + "Has been removed");
                        } else
                        {
                            Console.WriteLine(key1 + "Does not exsist");
                        }
                        break;
                    case "l":
                             foreach (var pair in codingLanguage)
                        {
                            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                        break;
                }
            } while (result != "e");

        }
    }
}
