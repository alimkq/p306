using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void Main()
    {
        int number = 6; 
        int result = Fibonacci(number);
        Console.WriteLine($"Число Фибоначчи с индексом {number} равно {result}");
    }
}
