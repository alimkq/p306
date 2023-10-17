using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main()
    {
        int number = 5;
        int result = Factorial(number);
        Console.WriteLine($"Факториал числа {number} равен {result}");
    }
}
