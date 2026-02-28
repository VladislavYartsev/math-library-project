using System;
using MathLib;

namespace MathLib.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO MathLib ===\n");

            Console.WriteLine("---- Арифметические операции ----");
            Console.WriteLine($"Add(5, 3) = {Calculator.Add(5, 3)}");
            Console.WriteLine($"Subtract(10, 4) = {Calculator.Subtract(10, 4)}");
            Console.WriteLine($"Multiply(6, 7) = {Calculator.Multiply(6, 7)}");
            Console.WriteLine($"Divide(20, 5) = {Calculator.Divide(20, 5)}");

            try
            {
                Calculator.Divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Divide(10,0) -> Ошибка: {ex.Message}");
            }

            Console.WriteLine("\n---- Проверка на простоту ----");
            int[] numbers = { 1, 2, 3, 4, 17, 25, 97 };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Prime({number}) = {Calculator.Prime(number)}");
            }

            Console.WriteLine("\n---- Возведение в степень ----");
            Console.WriteLine($"Power(2, 3) = {Calculator.Power(2, 3)}");
            Console.WriteLine($"Power(10, 3) = {Calculator.Power(10, 3)}");

            Console.WriteLine("\n---- Факториал ----");
            Console.WriteLine($"Factorial(5) = {Calculator.Factorial(5)}");

            try
            {
                Calculator.Factorial(-3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Factorial(-3) -> Ошибка: {ex.Message}");
            }
            try
            {
                Calculator.Factorial(13);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Factorial(13) -> Ошибка: {ex.Message}");
            }
            Console.WriteLine("\n---- Квадратное уравнение ----");

            double x1, x2;

            bool hasRoots = Calculator.SolveQuadratic(1, -3, 2, out x1, out x2);
            if (hasRoots)
            {
                Console.WriteLine("SolveQuadratic(1, -3, 2)");
                Console.WriteLine($"Корни: x1 = {x1}, x2 = {x2}");
            }

            hasRoots = Calculator.SolveQuadratic(1, 2, 5, out x1, out x2);
            Console.WriteLine("\nSolveQuadratic(1, 2, 5)");
            Console.WriteLine($"Есть действительные корни? {hasRoots}");
            try
            {
                Calculator.SolveQuadratic(0, 2, 1, out x1, out x2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SolveQuadratic(0,2,1) -> Ошибка: {ex.Message}");
            }

            Console.WriteLine("\n=== Тестирование завершено ===");
        }
    }
}