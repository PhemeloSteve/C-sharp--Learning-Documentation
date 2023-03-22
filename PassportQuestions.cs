/*
In this program we will be making use of nested if, else and else if statement
*/

using System;

public class Program
{
    public static void Main()
    {
        int Age;
        string Country;
        string Answer;
        bool hasPassport;

        Console.WriteLine("Enter your age:");
        Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Where are you travelling to:");
        Country = Console.ReadLine();

        Console.WriteLine("DO you have a Passport? (Yes or No)");
        Answer = Console.ReadLine();

        if (Answer == "Yes")
        {
            hasPassport = true;
        }
        else
        {
            hasPassport = false;
        }

        if (Age >= 18)
        {
            if (Country == "USA")
            {
                Console.WriteLine("You do not need a VISA to travel!");
            }

            else if (hasPassport == true)
            {
                Console.WriteLine("You may travel with a VISA!");
            }

            else
            {
                Console.WriteLine("You have no passpoer ypu may not travel.");
            }

        }

        else
        {
            Console.WriteLine("You are too young to travel");
        }

    }
}
