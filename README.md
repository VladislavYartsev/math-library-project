MathLib

MathLib — это простая библиотека на C#, содержащая базовые математические операции и дополнительные функции (проверка на простое число, факториал, решение квадратного уравнения и др.).

Пример:
using System;
using MathLib;

class Program
{
    static void Main()
    {
        // Сложение
        double sum = Calculator.Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        // Вычитание
        double difference = Calculator.Subtract(10, 4);
        Console.WriteLine($"10 - 4 = {difference}");

        // Умножение
        double product = Calculator.Multiply(6, 7);
        Console.WriteLine($"6 * 7 = {product}");

        // Деление
        double quotient = Calculator.Divide(20, 5);
        Console.WriteLine($"20 / 5 = {quotient}");

        // Проверка на простое число
        bool isPrime = Calculator.Prime(17);
        Console.WriteLine($"17 — простое число? {isPrime}");

        // Возведение в степень
        double power = Calculator.Power(2, 3);
        Console.WriteLine($"2^3 = {power}");

        // Факториал
        int factorial = Calculator.Factorial(5);
        Console.WriteLine($"5! = {factorial}");

        // Решение квадратного уравнения
        double x1, x2;
        bool hasRoots = Calculator.SolveQuadratic(1, -3, 2, out x1, out x2);

        if (hasRoots)
        {
            Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}