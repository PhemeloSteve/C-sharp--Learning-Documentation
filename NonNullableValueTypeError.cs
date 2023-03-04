using System;

public class CProgram
{
	public struct Point{public int X,Y;}
	
	public static void Main()
	{
		Point p1 = new Point();
		Console.WriteLine(p1);	// Cprogram+Point
		
		Point p2 = null;		// Compile-time error
		int z = null;			// Compile-time error
	}
}