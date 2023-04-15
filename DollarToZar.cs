/*
	In this program we will be converting Money from American dollar($) to South African Rands(ZAR)
*/
using System;

public class Program
{
	public static void Main()
	{
		// Declaring variables

		double dRate = 6.77; // Dollar Rand exchange rate
		string sAmount;
		double dAmount;
		
		// Taking user input amount, rate and Converting from dollar to ZAR
		
		Console.WriteLine("Enter the exchange rate for the amount of South African Rand (ZAR) per USD Dollar ($):");
		dRate = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the amount of money in $ you would like to convert to ZAR: ");
		sAmount = Console.ReadLine();
		dAmount = double.Parse(sAmount);
		
		dAmount *= dRate;
		
		// Displaying a message
		Console.WriteLine("Exchanging the amount of " + sAmount + "$ to (ZAR) at the exchange rate of " + dRate.ToString("0.00") + " will be equal to R" + dAmount.ToString("0.00"));
		
		// End of a code
		Console.WriteLine("\nPress any key to exit...");
		Console.ReadKey();
	}
}
