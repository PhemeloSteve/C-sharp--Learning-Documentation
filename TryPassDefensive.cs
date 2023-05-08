/*
    Program for making use of TryParse method for defensive programming
*/
using System;

public class Porgram
{
    public static void Main()
    {
        Console.WriteLine("Enter in a number: ");
        string userInput = Console.ReadLine();

        int number;

        // TryParse method will only convert userInput to int number variable iff it is possible
        bool success = int.TryParse(userInput,out number); // The out is comming from the TryParse method 

        if (success)
        {
            Console.WriteLine("Successfully converted to int: " + number);
        }
        else
        {
            Console.WriteLine("Unseccessfull conversion");

        }
    }
}
