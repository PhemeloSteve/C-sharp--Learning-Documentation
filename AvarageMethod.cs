/*
    In this Program we wiil be making use of method to returna double avarage form two user input marks and display a message
*/

using System;

public class Program
{
    public static void Main()
    {
        double dAvarage = Avarage();
        GenerateMsg(dAvarage);

    }

    static double Avarage()
    {
        Console.WriteLine("Enter in first mark: ");
        int iMark1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a second mark: ");
        int iMark2 = int.Parse(Console.ReadLine());

        double avarage = (iMark1 + iMark2)/2.0;

        return avarage;
    }



    static void GenerateMsg(double _dAvarage)
    {
       Console.WriteLine("Your avarge is: " + _dAvarage.ToString("0.00"));
    }

}
