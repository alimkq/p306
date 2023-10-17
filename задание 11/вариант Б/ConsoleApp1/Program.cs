using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your weight (in kg):");
        double weight, height;

        if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
        {
            Console.WriteLine("Enter your height (in meters):");

            if (double.TryParse(Console.ReadLine(), out height) && height > 0)
            {
                double normalBmiStart = 18.5 * height * height;
                double normalBmiEnd = 24.9 * height * height;

                double minimumWeight = normalBmiStart - weight;
                double maximumWeight = normalBmiEnd - weight;

                if (minimumWeight > 0)
                {
                    Console.WriteLine($"To normalize your weight, it is recommended to lose {minimumWeight:F2} kg.");
                }
                else if (maximumWeight < 0)
                {
                    Console.WriteLine($"To normalize your weight, it is recommended to gain {Math.Abs(maximumWeight):F2} kg.");
                }
                else
                {
                    Console.WriteLine("Your weight is already within the normal range. Everything is fine!");
                }
            }
            else
            {
                Console.WriteLine("Input error. Please enter a valid height.");
            }
        }
        else
        {
            Console.WriteLine("Input error. Please enter a valid weight.");
        }
    }
}
