using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[,] arrayy = new int[5, 5]
            {
            {0, 1, 2, 3,4},
            {5, 6, 7, 8,9},
            {10, 11, 12, 13,14},
            {15, 16,17, 18,19},
            {20, 21, 22, 23,24}
            };

            for (int i=0; i<arrayy.GetLength(0); i++) 
            {
                for(int j = 0; j<arrayy.GetLength(1); j++) 
                {
                    result += arrayy[i, j];
                    Console.WriteLine(result);
                }
                

            }

            int[] test = new int[5];
            for(int i = 0; i < test.Length; i++)
            {
                Console.WriteLine("Enter numbers");
                test[i] = Convert.ToInt32(Console.ReadLine());
                result += test[i]/test.Length;
                
            }
            Console.WriteLine("The average of the array is " + result);
        }
        
    }

}
