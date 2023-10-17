public class Program
{
    public static void Main()
    {
        Console.WriteLine("Здравствуйте, не могли бы вы заполнить анкету?");

        Console.WriteLine("Ваше имя?");
        string name = Console.ReadLine();

        Console.WriteLine("Ваша фамилия?");
        string surname = Console.ReadLine();

        Console.WriteLine("Ваша возраст?");
        string age = Console.ReadLine();

        Console.WriteLine("Ваша ваш рост?");
        string height = Console.ReadLine();

        Console.WriteLine("Ваша ваш вес?");
        string weight = Console.ReadLine();

        Console.WriteLine(name + " " + surname + ": " + age + " лет, " + height + " см., " + weight + " кг.");
        Console.WriteLine("{0} {1}: {2} лет, {3} см., {4} кг.", name, surname, age, height, weight);
        //Console.WriteLine($"{name} {surname}: {age} лет, {height} см., {weight} кг.");
    }
}