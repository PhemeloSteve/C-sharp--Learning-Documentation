/*
This program will be making use of recussion to calculate the factorial of a number
that is entered by a user
*/

using System;

public class Program
{
    public static void Main()
    {
        int n;
        Console.Write("Enter a number a natural number that you want to calculate factorial of:");
        n = int.Parse(Console.ReadLine());
        
        if (n<0)
        {
            Console.WriteLine("The factorial of a number you have enter is invalid ");
            Console.WriteLine("Please try again!!!");
            Console.WriteLine();
            
            Main();
        }
        
        else
        {
            Console.WriteLine("The number "+n+" has a factorial of "+Fact(n));
        }
        
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    public static int Fact(int n)
    {
        if (n>1)
        {
            return n*Fact(n-1);
        }
        else 
        {
            return 1;
        }
    }
}
