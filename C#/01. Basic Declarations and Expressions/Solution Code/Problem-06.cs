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

        int num3;
        Console.WriteLine("Input the Third Number : ");
        num3 = int.Parse(Console.ReadLine());
        
        int result = num1 * num2 * num3;
        Console.WriteLine(num1 + "x" + num2 + "x" + num3 + "=" + result);
        
    }
}
