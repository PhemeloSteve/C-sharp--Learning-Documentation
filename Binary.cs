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
            // Declaring decimal int variable and string for the sBinary to store our binary in
            
            int i;
            string num;
            string sBinary = "";

            // Taking user input for decimal integer value we want to convert to binary number
            
            Console.Write("Enter a decimal number that you want to convert to binary number: ");
            num = Console.ReadLine();


            i = int.Parse(num);

            // Calculating the binary using do-while loop
            do
            {
                sBinary= i%2 + sBinary; // adding the remainder in a revers order
                i/=2;
            }
            while(i != 0);
            
            // Displaying message
            Console.WriteLine("\nThe binary number of the decimal number " + num + " is " + sBinary + ".");

            // End of a code
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
