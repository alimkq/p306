using System;

struct ComplexNumber
{
    public double Real;
    public double Imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Методы для операций с комплексными числами
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
    }

    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        return new ComplexNumber(Real * other.Real - Imaginary * other.Imaginary, Real * other.Imaginary + Imaginary * other.Real);
    }

    public ComplexNumber Divide(ComplexNumber other)
    {
        double denominator = other.Real * other.Real + other.Imaginary * other.Imaginary;
        double realPart = (Real * other.Real + Imaginary * other.Imaginary) / denominator;
        double imaginaryPart = (Imaginary * other.Real - Real * other.Imaginary) / denominator;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    // Перегрузка операторов для удобства использования
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Add(c2);
    }

    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Subtract(c2);
    }

    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Multiply(c2);
    }

    public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Divide(c2);
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber complex1 = new ComplexNumber(2, 3);
        ComplexNumber complex2 = new ComplexNumber(1, 4);

        // Использование методов
        ComplexNumber sum = complex1.Add(complex2);
        ComplexNumber difference = complex1.Subtract(complex2);
        ComplexNumber product = complex1.Multiply(complex2);
        ComplexNumber quotient = complex1.Divide(complex2);

        // Использование операторов
        ComplexNumber sumOperator = complex1 + complex2;
        ComplexNumber differenceOperator = complex1 - complex2;
        ComplexNumber productOperator = complex1 * complex2;
        ComplexNumber quotientOperator = complex1 / complex2;

        // Вывод результатов
        Console.WriteLine($"Сумма: {sum.Real} + {sum.Imaginary}i");
        Console.WriteLine($"Разность: {difference.Real} + {difference.Imaginary}i");
        Console.WriteLine($"Произведение: {product.Real} + {product.Imaginary}i");
        Console.WriteLine($"Частное: {quotient.Real} + {quotient.Imaginary}i");

        Console.WriteLine($"Сумма (оператор): {sumOperator.Real} + {sumOperator.Imaginary}i");
        Console.WriteLine($"Разность (оператор): {differenceOperator.Real} + {differenceOperator.Imaginary}i");
        Console.WriteLine($"Произведение (оператор): {productOperator.Real} + {productOperator.Imaginary}i");
        Console.WriteLine($"Частное (оператор): {quotientOperator.Real} + {quotientOperator.Imaginary}i");
    }
}
