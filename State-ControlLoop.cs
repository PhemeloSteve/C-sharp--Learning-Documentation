/*
    In this program we will be implimenting state-Control loop
    That allow user to keep entering marks in so long as they keep entering the Character 'Y' 
*/

using System;

public class Program
{
    public static void Main()
    {
        int count = 0;
        int total = 0;
        double avarage;
        char input = 'Y';

        while(input == 'Y')
        {
            Console.Write("Enterin a mark: ");
            int mark = int.Parse(Console.ReadLine());
            total += mark;
            count ++;

            Console.WriteLine("Enter another mark Y/N?");
            input = char.Parse(Console.ReadLine().ToUpper());

        }
        avarage = (double)total/count;
        Console.WriteLine("The avarage of all the marks is: " + avarage.ToString("0.00"));

        // End of a code
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
