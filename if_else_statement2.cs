/*
This is part 2 of implimenting if else statement
*/

using System;
					
public class Program
{
	public static void Main()
	{
		int Mark1;
		int Mark2;
		int Mark3;
		
		Console.WriteLine("Enter in Mark1");
		Mark1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter in Mark2");
		Mark2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter in Mark3");
		Mark3 = int.Parse(Console.ReadLine());
		
		if (Mark1 > Mark2)
		{
			if (Mark1 > Mark3)
			{
				Console.WriteLine("Mark1 is the Greatest");
			}
			else
			{
				Console.WriteLine("Mark3 is the Greatest");
			}
		
		}
		else
		{
			if (Mark2 > Mark3)
			{
				Console.WriteLine("Mark2 is the Greatest");
			}
			else
			{
				Console.WriteLine("Mark3 is the greatest");
			}
		}
	}
}