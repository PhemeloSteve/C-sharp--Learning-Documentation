//Name: Phemelo Mokwena
//Student Number: 2023129683
//Practical 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration student 1 variables

            string sName1;
            int iStudentNumber1;
            int iAge1;
            int iMark1;

            //Declaration student 2 variables

            string sName2;
            int iStudentNumber2;
            int iAge2;
            int iMark2;

            //Declaration student 3 variables
            string sName3;
            int iStudentNumber3;
            int iAge3;
            int iMark3;

            //Read in Student 1's details

            Console.WriteLine("Enter the first student's name:");
            sName1 = Console.ReadLine();
            Console.WriteLine("Enter the first student's number:");
            iStudentNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first student's age:");
            iAge1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first student's mark:");
            iMark1 = int.Parse(Console.ReadLine());
            Console.Clear();

            //Read in Student 2's details

            Console.WriteLine("Enter the second student's name:");
            sName2 = Console.ReadLine();
            Console.WriteLine("Enter the second student's number:");
            iStudentNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second student's age:");
            iAge2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second student's mark:");
            iMark2 = int.Parse(Console.ReadLine());
            Console.Clear();

            //Read in Student 3's details

            Console.WriteLine("Enter the third student's name:");
            sName3 = Console.ReadLine();
            Console.WriteLine("Enter the third student's number:");
            iStudentNumber3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third student's age:");
            iAge3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third student's mark:");
            iMark3 = int.Parse(Console.ReadLine());
            Console.Clear();

            //Calculate class average

            double dAvarage;
            dAvarage = (iMark1 + iMark2 + iMark3) / 3.00;

            //Output results
            Console.WriteLine(sName1 + " (Student number " + iStudentNumber1 + ") has a mark of " + iMark1);
            Console.WriteLine(sName2 + " (Student number " + iStudentNumber2 + ") has a mark of " + iMark2);
            Console.WriteLine(sName3 + " (Student number " + iStudentNumber3 + ") has a mark of " + iMark3);

            Console.WriteLine("Class avarage is: " + dAvarage.ToString("0.00"));

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}
