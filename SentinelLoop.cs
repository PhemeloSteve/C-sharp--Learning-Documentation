/*
    In this program we will be implimenting sentinel loop 
*/

using System;

public class Program
{
    public static void Main()
    {
        int num = 0;

        while( num != -1)
        {
            Console.Write("Enter a number (Enter -1 to Exit): ");
            num = int.Parse(Console.ReadLine());

            if (num != -1)
            {
                Console.WriteLine("You have entered : " + num.ToString());
            }
        }

        Console.WriteLine("You have ended your program");

        // End of a code
        Console.WriteLine("\nEnter any key to exit...");
        Console.ReadKey();

    }
}
