using System;
					
public class Program
{
	public static void Main()
	{
		double x;
		double y; 
		double z; 
		string sMsg;
		int ix;
		
		int iTime = 4000;
		x = iTime/3600.0;
		//Console.WriteLine(x);
		
		y= x - ((int)x);
		y = y*60;
		//Console.WriteLine("The answer is: " + y);
		
		z = y - ((int)y);
		z = z*60;
		//Console.WriteLine(z);
		ix = (int)x;
		int iy = (int)y;
		int iz = (int)z;
		
		//Console.WriteLine("4000s =" + (int)x + ":" + "0" + (int)y + ":" + (int)z);
		sMsg = iTime.ToString()+"s is = " + ix.ToString("D2") + ":" + iy.ToString("D2") + ":" + iz.ToString("D2");
		Console.WriteLine(sMsg);
		//Console.WriteLine(z);
		Console.WriteLine("Done!!");
	}
}
