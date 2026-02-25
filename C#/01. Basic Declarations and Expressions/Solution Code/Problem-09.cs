//C# Solution:
using System;

class Program 
{
    static void Main(string[] args)
    {
        int num1;
        Console.Write("Enter the First number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        int num2;
        Console.Write("Enter the Second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int num3;
        Console.Write("Enter the Third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int num4;
        Console.Write("Enter the Fourth number: ");
        num4 = Convert.ToInt32(Console.ReadLine());
        
        int avg = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + " is: " + avg);

    }
}
