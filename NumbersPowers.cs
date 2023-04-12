/*
	This program allow a user to enter a number and calculate the square root as well as the square of that number
*/

using System;

public class Program
{
	public static void Main()
	{
		// Decleration of variable
		double x, rootx,xx;
		
		// Prompting user data
		
		Console.Write("Enter a positive number that you want to calculate square and square root of: ");
		x = double.Parse(Console.ReadLine());
		
		// Calculations
		xx = Math.Pow(x, 2.0);
		rootx = Math.Sqrt(x);
		
		// Displaying a massage
		
		Console.WriteLine("\nThe number you have entered is "+ x.ToString());
		Console.WriteLine("It's square is: " + xx.ToString());
		Console.WriteLine("It's square root is : " + rootx.ToString());
			
		// End of a code
		Console.WriteLine("\nPress any key to exit...");
		Console.ReadKey();
		
	}
}
