using System;
class AddTwoNumbers
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("Addition of " + a + " and " + b + " is = " + sum);
    }
}
