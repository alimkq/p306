using System;

class Program
{
    static double Power(double baseNumber, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent > 0)
        {
            return baseNumber * Power(baseNumber, exponent - 1);
        }
        else
        {
            return 1 / (baseNumber * Power(baseNumber, -exponent - 1));
        }
    }

    static void Main()
    {
        double baseNumber = 2.5; 
        int exponent = -3; 
        double result = Power(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} в степени {exponent} равно {result}");
    }
}
