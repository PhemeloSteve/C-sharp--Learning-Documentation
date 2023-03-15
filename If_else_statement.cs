/*
Program that impliment if and else statement
*/
using System;

{
    class Program
    {
        public static void Main()
        {
            int Mark1;
            int Mark2;
            double Avarage;

            Console.WriteLine("Enter Mark 1:");
            Mark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mark2:");
            Mark2 = int.Parse(Console.ReadLine());

            Avarage = (Mark1 + Mark2)/2.00; //Avarage of the two marks

            if (Avarage >= 50)
            {
                Console.WriteLine("The student passed");
                if (Avarage >= 80)
                {
                    Console.WriteLine("Students has a distiction");
                }
                else 
                {
                    Console.WriteLine("But did'nt get a distiction.");
                }
            }

            else
            {
                if (Avarage >= 45)
                {
                    Console.WriteLine("The student qualify for a re-assament.");
                }
                else

                {
                    Console.WriteLine("The student did'nt pass!");
                }

            }
        }

    }
}