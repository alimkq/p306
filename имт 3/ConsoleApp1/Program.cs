
{
    Console.WriteLine("Ваша ваш рост (м.)?");
    double height = Double.Parse(Console.ReadLine());

    Console.WriteLine("Ваша ваш вес (кг.)?");
    double weight = Double.Parse(Console.ReadLine());

    double index = weight / (height * height);

    Console.WriteLine("Ваш индекс массы тела: " + index.ToString("N2"));
}