//Mokwena Phemelo
//2023129683
//Practical 3 (StudentAge)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student's Birth year variables

            int Student1BirthYear;
            int Student2BirthYear;
            int Student3BirthYear;

            // Read Input for Students Birth year

            Console.WriteLine("Enter the birth year of the first student:");
            Student1BirthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the birth year of the second student:");
            Student2BirthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the birth year of the third student:");
            Student3BirthYear = int.Parse(Console.ReadLine());

            // Determining Oldest Student and Display Message

            if (Student1BirthYear < Student2BirthYear)
            {
                if (Student1BirthYear < Student3BirthYear)
                {
                    Console.WriteLine("The first student is the oldest.");
                }
                else
                {
                    Console.WriteLine("The third student is the oldest.");
                }
            }
            else 
            {
                if (Student2BirthYear < Student3BirthYear)
                {
                    Console.WriteLine("The second student is the oldest.");
                }
                else 
                {
                    Console.WriteLine("The third is the oldest.");
                }
            }


            //End of the Code

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
