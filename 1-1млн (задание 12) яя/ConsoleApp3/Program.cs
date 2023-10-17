using System;

class Program
{
    // Метод для вычисления суммы цифр числа
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int goodNumbersCount = 0;
        int rangeStart = 1;
        int rangeEnd = 1000000000;

        DateTime startTime = DateTime.Now;

        for (int i = rangeStart; i <= rangeEnd; i++)
        {
            if (i % SumOfDigits(i) == 0)
            {
                goodNumbersCount++;
            }
        }

        DateTime endTime = DateTime.Now;
        TimeSpan executionTime = endTime - startTime;

        Console.WriteLine($"Number of 'good' numbers in the range from {rangeStart} to {rangeEnd}: {goodNumbersCount}");
        Console.WriteLine($"Program execution time: {executionTime.TotalSeconds} seconds");
    }
}

