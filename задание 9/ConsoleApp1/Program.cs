using System;

class Program
{
    static void Main()
    {
        int number;
        int sum = 0;

        Console.WriteLine("Enter numbers (enter 0 to finish input):");

        do
        {
            number = int.Parse(Console.ReadLine());

            if (number > 0 && number % 2 != 0)
            {
                sum += number;
            }

        } while (number != 0);

        Console.WriteLine($"Sum of all positive odd numbers: {sum}");
    }
}

