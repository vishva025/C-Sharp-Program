using System;
class Program
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        String Name = Console.ReadLine();
        Console.Write("Enter country name: ");
        String Country = Console.ReadLine();
        Console.WriteLine("Hello " + Name + " from country " + Country);
    }
}
