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
                double bodyMassIndex = weight / (height * height);

                Console.WriteLine($"Your body mass index (BMI): {bodyMassIndex:F2}");

                if (bodyMassIndex < 18.5)
                {
                    Console.WriteLine("You are underweight. It is recommended to gain weight.");
                }
                else if (bodyMassIndex >= 18.5 && bodyMassIndex < 24.9)
                {
                    Console.WriteLine("You have a normal weight. Everything is fine!");
                }
                else
                {
                    Console.WriteLine("You are overweight. It is recommended to lose weight.");
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
