using System;
					
public class Program
{
	public static void Main()
	{
		int iNum1, iNum2, iNum3, iLength;
		
		Console.Write("Enter the first number: ");
		iNum1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		iNum2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the third number: ");
		iNum3 = int.Parse(Console.ReadLine());
		
		Console.Write("How many number in the sequence would you like to print? ");
		iLength = int.Parse(Console.ReadLine());
		
		int [] Output = Tribonacci(iNum1,iNum2,iNum3,iLength); 
		
		foreach (int i in Output)
		{
			Console.Write(i.ToString() + " ");
		}
	}
	public static int [] Tribonacci(int _iNum1, int _iNum2,
								int _iNum3, int _iLength)
	{
		int [] iSequence = new int[_iLength];
		iSequence[0] = _iNum1;
		iSequence[1] = _iNum2;
		iSequence[2] = _iNum3;
		
		for (int i = 3; i<=_iLength-1;i++)
		{
			int iSum = iSequence[i-3] + iSequence[i-2] + iSequence[i-1];
			iSequence[i] = iSum;
		}
			
		return iSequence; 
	}
}
