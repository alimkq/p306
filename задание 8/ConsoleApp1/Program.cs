using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits in the number: {digitCount}");
    }

    static int CountDigits(int number)
    {
        int digitCount = 0;

        // Convert the number to its absolute value to avoid issues with negative numbers
        number = Math.Abs(number);

        // Count the number of digits
        while (number > 0)
        {
            number /= 10;
            digitCount++;
        }

        return digitCount;
    }
}
