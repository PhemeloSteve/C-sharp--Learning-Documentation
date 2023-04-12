/*
    In this code we will be converting number of days into Years, Months, Weeks and days using the mod operation
*/

using System;

public class Program
{
    public static void Main()
    {
        // Decleration of usefula variables
        string sDays,sMsg;
        int iDays, iWeeks, iMonths, iYears;

        // Prompting user input for number of days

        Console.Write("Enter a number of days to convert into years, months, weeks and days: ");
        sDays  = Console.ReadLine();

        // Calcualtions and Convertion

         iDays = int.Parse(sDays);

        // Getting number of days
        iYears = iDays/365;

        //remening days
        iDays = iDays % 365;

        // Getting Months
        iMonths = iDays/30;

        //Remaining days
        iDays = iDays % 30;

        // Getting weeks
        iWeeks = iDays/7;

        // Remaining Days
        iDays = iDays%7;

        // Displaying a massage

        sMsg = "\n" + sDays + " Days = " + iYears.ToString() + " years + " + iMonths.ToString() + " months + " + iWeeks.ToString() + " weeks + " + iDays.ToString() + " days.\n";

        Console.WriteLine(sMsg);

        //End of the code
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

}
