/*
	This Program explore th use of constructer,
	instance field, static field and default values 
	of static field
*/
using System;

public class CPanda
{
	public string Name;	//Instance field
	public static int Population;	//static field
	
	public CPanda(string n) //Constructer
	{
		Name = n;	//Assign the instance field
		Population = Population + 1;
	}
}

public class Test
{
	static int x;	//static field
	static bool c;	//static field
	public static void Main()
	{
		Console.WriteLine(c);
		Console.WriteLine(CPanda.Population);
		CPanda p1 = new CPanda("James");
		CPanda p2 = new CPanda("Kabelo");
		CPanda p3 = new CPanda("John");
		
		Console.WriteLine(p3.Name);
	}
}