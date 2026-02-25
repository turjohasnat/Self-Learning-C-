//C# Solution:
using System;

class Program 
{
    static void Main(string[] args)
    {
        int num1;
        Console.WriteLine("Input the First Number : ");
        num1 = int.Parse(Console.ReadLine());

        int num2;
        Console.WriteLine("Input the Second Number : ");
        num2 = int.Parse(Console.ReadLine());

        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        
        Console.WriteLine("After Swapping: ");
        Console.WriteLine("First Number:" + num1);
        Console.WriteLine("Second Number:" + num2);
        
    }
}
