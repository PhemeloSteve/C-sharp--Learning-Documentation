/*
    In this program we will be making use of defensive programming while taking two inputs for Litres and Km
    and determine if a trip is possible
*/
using System;

public class Program
{
    public static void Main()
    {
        int iKm;
        double dLitre;

        Console.WriteLine("Enter in the number of km's: ");
        bool isValidKm = int.TryParse(Console.ReadLine(), out iKm);

        Console.WriteLine("Enter in number of Litres: ");
        bool isValidLitre = double.TryParse(Console.ReadLine(), out dLitre);

        if (isValidLitre && isValidKm)
        {
            if (dLitre>0 && iKm>dLitre)
            {
                double dConsumption = iKm/dLitre;
                Console.WriteLine("Your Consumption was: " + dConsumption.ToString("0.0") + " Km/L");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    
    }
}
