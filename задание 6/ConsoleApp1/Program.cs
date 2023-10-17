using System;

class Program
{
    static void Main()
    {
        string name = "Alim";
        string surname = "Tulegenov";
        string city = "Aktobe";

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Surname: " + surname);
        Console.WriteLine("City: " + city);

        // Determining the width of the console window for centering
        int width = Console.WindowWidth;

        // Determining the lengths of the strings
        int length_name = name.Length;
        int length_surname = surname.Length;
        int length_city = city.Length;

        // Calculating positions for centering
        int name_position = (width - length_name) / 2;
        int surname_position = (width - length_surname) / 2;
        int city_position = (width - length_city) / 2;

        // Printing strings in the center of the screen
        Console.SetCursorPosition(name_position, Console.CursorTop);
        Console.WriteLine(name);

        Console.SetCursorPosition(surname_position, Console.CursorTop);
        Console.WriteLine(surname);

        Console.SetCursorPosition(city_position, Console.CursorTop);
        Console.WriteLine(city);
    }
}
