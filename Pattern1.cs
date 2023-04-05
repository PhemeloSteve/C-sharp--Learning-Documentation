/*
 This Program take in users name and displayes some message and a pattern with (¥) at the middle
*/

using System;

public class Program
{
    public static void Main()
    {
        //Decleration of useful variables
        
        string Name;
        int n = 165;
        char charX;
        charX = (char)n;

        // Taking user input Name
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();

        // Output

        Console.WriteLine("  _");
        Console.WriteLine(" / \\");
        Console.WriteLine("( " + charX + " )");
        Console.WriteLine(" \\_/\n");
        Console.WriteLine(Name + " says: \"I love programming!\"\n");

        // End of a code
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
