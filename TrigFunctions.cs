/*
	In this program we will be taking an angle from a user in degrees and calculate the sin cos and tan of that angle
*/

using System;

public class Program
{
	public static void Main()
	{
		// Declerations of variables
		double dAngle, x;
		double sinx, cosx, tanx;
		
		// Prompting user input of the angle in degrees
		
		Console.Write("Enter an angle in degrees: ");
		dAngle = double.Parse(Console.ReadLine());
		
		// Calculations and conversions
		
		x = dAngle * Math.PI/180.00;
		
		sinx = Math.Sin(x);
		cosx = Math.Cos(x);
		tanx = Math.Tan(x);
		
		// Displaying a message
		Console.WriteLine("\nsin("+dAngle.ToString()+") = "+ sinx.ToString("0.000"));
		Console.WriteLine("cos("+dAngle.ToString()+") = "+ cosx.ToString("0.000"));
		Console.WriteLine("tan("+dAngle.ToString()+") = "+ tanx.ToString("0.000"));
		
		// End of the code 
		Console.WriteLine("/nPress any key to exit...");
		Console.ReadKey();
	}
}
