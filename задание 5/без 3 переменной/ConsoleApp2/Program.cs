using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Исходные значения: a = {a}, b = {b}");

        // Обмен значениями без использования третьей переменной
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }
}
