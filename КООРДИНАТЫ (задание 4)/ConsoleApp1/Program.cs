Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Введите координату X первой точки  A: ");
Console.ForegroundColor = ConsoleColor.Green;
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Введите координату Y первой точки B: ");
Console.ForegroundColor = ConsoleColor.Green;
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Введите координату X второй точки C: ");
Console.ForegroundColor = ConsoleColor.Green;
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Введите координату Y второй точки D: ");
Console.ForegroundColor = ConsoleColor.Green;
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double Rast = 0;


Rast = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Расстояние между точками с координатами A = {0}, B = {1}, C = {2}, D = {3} равно: ", A, B, C, D);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("{0:0.00}", Rast);
Console.WriteLine();