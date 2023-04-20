/*
    In this program we will be taking an integer(dec) from a user and convert it to binary form 
*/

using System;

namespace Binary
{
    public class Program
    {
        public static void Main()
        {
            int i;
            string num;
            string sBinary = "";

            Console.Write("Enter a decimal number that you want to convert to binary number: ");
            num = Console.ReadLine();


            i = int.Parse(num);

            // Calculating the binary using while loop
            do
            {
                sBinary= i%2 + sBinary;
                i/=2;
            }
            while(i != 0);

            Console.WriteLine("\nThe binary number of the decimal number " + num + " is " + sBinary + ".");

            // End of a code
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
