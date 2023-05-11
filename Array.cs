/*
	Basic Array and foreach loop
*/

using System;
					
public class Program
{
	public static void Main()
	{
		int n = 0;
		int [] score = new int[14];
		for (int i =1; i<15; i++)
		{
			
			score[n] = i;
			n++;
		}
		foreach (int m in score)
		{
			Console.WriteLine(m);
		}
	}
}
