using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp;

        Console.WriteLine($"Исходные значения: a = {a}, b = {b}");

        // Обмен значениями с использованием третьей переменной
        temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }
}
