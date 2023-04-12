/*
In this program we will be taking input of number of days and convert it to the format of
Years + months + weeks + days 
Without making use of mod operation
*/

using System;

public class Program
{
    public static void Main()
    {
        //Decleration of input variable
        int x;

        // Declration of The final format of our variables
        int iYears, iMonths, iWeeks, iDays;

        // Decleration of variables that will be used 
        double dYears, dMonths, dWeeks, dDays;

        // Taking input of number of days from user

        Console.Write("Enter a number of days to convert into years, months. weeks and days: ");
        x = int.Parse(Console.ReadLine());

        //Mathamatical convertions

        dYears = x/365.000000;
        iYears= (int)dYears;

        dMonths = (dYears - iYears)*12;
        iMonths = (int)dMonths;

        dWeeks = (dMonths - iMonths)*4;
        iWeeks = (int)dWeeks;

        dDays = (dWeeks - iWeeks)*7;
        iDays = (int)dDays;

        Console.WriteLine(dWeeks);

        Console.WriteLine(x + " days = " + iYears.ToString()+ " years + " + iMonths.ToString() + " months + " + iWeeks.ToString() + " weeks + " + iDays.ToString() + " days.");

        //End of the code
        Console.ReadKey();
        Console.WriteLine("Press any key to exit");


    }
}
