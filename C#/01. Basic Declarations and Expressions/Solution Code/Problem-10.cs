//C# Solution:
using System;

class Program 
{
    static void Main(string[] args)
    {
        int x;
        Console.Write("Enter the First number: ");
        x = Convert.ToInt32(Console.ReadLine());

        int y;
        Console.Write("Enter the Second number: ");
        y = Convert.ToInt32(Console.ReadLine());

        int z;
        Console.Write("Enter the Third number: ");
        z = Convert.ToInt32(Console.ReadLine());

        int ans1 = (x + y) * z;
        Console.WriteLine(ans1);
        
        int ans2 = x * y + y * z;
        Console.WriteLine(ans2);
    }
}
