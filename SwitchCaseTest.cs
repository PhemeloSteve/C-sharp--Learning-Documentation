/*
In thisprogram we will be taking an input of number of a card and we will return what that card is
*/

using System;

public class Program
{
    public static void Main()
    {
        // Decleration of a Card Number
        int n;
        
        // Taking input of a card number from a user

        Console.Write("Enter a card number: ");
        n = int.Parse(Console.ReadLine());

        //Switch case statement
        switch(n)
        {
            case 13:
                Console.WriteLine("King");
                break;
            case 12:
                Console.WriteLine("Queen");
                break;
            case 11:
                Console.WriteLine("Jack");
                break;
            case -1:
                goto case 12;
            default:
                Console.WriteLine(n);
                break;
        }
    }

}
