//C# Solution:
using System;

class Program 
{
    static void Main(string[] args)
    {
        int num1;
        Console.Write("Input the first number: ");
        num1 = int.Parse(Console.ReadLine());
        
        int num2;
        Console.Write("Input the second number: ");
        num2 = int.Parse(Console.ReadLine());
        
        int result_1 = num1 + num2;
        Console.WriteLine(num1 + "+" + num2 + "=" + result_1);
        
        int result_2 = num1 - num2;
        Console.WriteLine(num1 + "-" + num2 + "=" + result_2);
        
        int result3 = num1 * num2;
        Console.WriteLine(num1 + "*" + num2 + "=" + result3);
        
        int result4 = num1 / num2;
        Console.WriteLine(num1 + "/" + num2 + "=" + result4);
        
        int result5 = num1 % num2;
        Console.WriteLine(num1 + "%" + num2 + "=" + result5);
        
    }
}
