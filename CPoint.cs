/*
This Program the nature of Reference Type
by implimenting struct reference method and class reference type
*/

using System;

public class CProgram
{
    public struct Point{public int X,Y;}
    
    public static void Main()
    {
        Point p1 = new Point();
        p1.X = 7;
        Point p2 = p1;
        
        p1.X = 9;
        Console.WriteLine(p1.X);
        Console.WriteLine(p2.X);
        
        // Focusing on class CPoint
        CPoint cp1 = new CPoint();
        //cp1 = 10;
        cp1.X = 10;
        
        CPoint cp2 = cp1;
        cp1.X = 25; //This will also result in cp2.X to have the same X value as cp1.X since they have the same reference point in memory

        Console.WriteLine(cp1.X);
        Console.WriteLine(cp2.X);
        
    }
    
}

public class CPoint
{
    public int X,Y;
}