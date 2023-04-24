/*
	In this program we will be making use of method to print out a greeting message by taking users input name and surname
*/

using System;
					
public class Program
{
	public static void Main()
	{
		string name, surname;
		
		Console.WriteLine("Enter your first name: ");
		name = Console.ReadLine();
		
		Console.WriteLine("Enter your second name: ");
		surname = Console.ReadLine();
		
		string greeting = GeneratingGreating(name, surname);
		Console.WriteLine(greeting);
		
		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
	
	public static string GeneratingGreating(string name, string surname)
	{
		return "Hi, " + name + " " + surname + "! Welcome to the program!";
	}
}
