/*
  In this program we will be making a matrix of 3x3 called grid and assign numbers to positions and display the outcome
*/
using System;
					
public class Program
{
	public static void Main()
	{
    //Decleration of a matrix
		int[,] grid = new int[3,3];
    
		// Assigning values to the grid
		grid[0,0] = 4;
		grid[0,1] = 6;
		grid[0,2] = 9;
		grid[1,0] = 3;
		grid[1,1] = 7;
		grid[1,2] = 8;
		grid[2,0] = 5;
		grid[2,1] = 1;
		grid[2,2] = 0;

    // looping through a nested for loop to display the grid 3x3 matrix
    Console.WriteLine("Grid matrix. \n");
		for (int i = 0; i<=2; i++)
		{
			for (int j = 0; j<=2; j++)
			{
				Console.Write(grid[i,j].ToString() + " ");
			}
			Console.WriteLine("\n");
		}
		Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
	}
}
