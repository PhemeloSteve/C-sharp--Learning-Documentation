/*
    In this Program we will be taking users input and using for loop to display half side of a christmas tree.
*/

using System;

public class Program
{
    public static void Main()
    {
        int x;
        Console.WriteLine("Enter a number of columns for your shape");
        x = int.Parse(Console.ReadLine());

        Console.Clear();

        for (int i=0; i<=x; i++)
        {
            for (int j=0; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // End of the code
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
