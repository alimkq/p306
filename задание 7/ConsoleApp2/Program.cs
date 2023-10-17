using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int minimum = FindMinimum(num1, num2, num3);
        Console.WriteLine($"Minimum number: {minimum}");
    }

    static int FindMinimum(int a, int b, int c)
    {
        int minimum = a;

        if (b < minimum)
        {
            minimum = b;
        }

        if (c < minimum)
        {
            minimum = c;
        }

        return minimum;
    }
}
