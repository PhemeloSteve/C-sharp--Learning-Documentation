/*
 In this program we will be exploring the use of Jagged Arrays
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sMsg = "Jagged Arrays.\n";

            Console.WriteLine(sMsg);

            // Declration and initiation fo Jagged array

            int[][] numbers = new int[][]
                {
                    new int[] { 10, 20, 30 },
                    new int[] { 40, 50 },
                    new int[] { 60, 70, 80, 90 }
                };

            // Accessing elements in Jagged array numbers 
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    int iNum = numbers[i][j];
                    Console.Write(iNum + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
