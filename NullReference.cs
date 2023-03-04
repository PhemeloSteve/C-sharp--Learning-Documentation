/*
The following code explore the reference being assigned to null which shows that reference points to no object
*/

using System;
					
class Point{public int X,Y;}

public class Test
{
	public static void Main()
	{
		Point p1 = new Point ();
		p1 = null;
		Console.WriteLine(p1==null);
		Console.WriteLine(p1.X);	// Run-time error: Null Reference Exception.
	}
}