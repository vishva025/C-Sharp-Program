using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter No 1: ");
        Int32 no1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter No 2: ");
        Int32 no2 = Convert.ToInt32(Console.ReadLine());
        
        no1 = no1 + no2;
        no2 = no1 - no2;
        no1 = no1 - no2;
        Console.WriteLine("No1: {0}, No2: {1}", no1, no2);
    }
}