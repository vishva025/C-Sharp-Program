using System;
class Area
{
    public static void Main()
    {
        Double lengthInFeets = 0, widthInFeets = 0, plotArea = 0;
        Console.Write("Enter length in feets: ");
        lengthInFeets = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width in feet:");
        widthInFeets = Convert.ToInt32(Console.ReadLine());
        plotArea = lengthInFeets * widthInFeets;
        Console.WriteLine("Area is " + plotArea + " square feet");
    }
}