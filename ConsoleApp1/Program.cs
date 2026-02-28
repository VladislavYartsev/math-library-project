using MathLib;
using System.Security.Cryptography;

namespace MathLib.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Calculator.Add(1, 2));

            Console.WriteLine(Calculator.Divide(1, 3));

            Console.WriteLine(Calculator.Multiply(3, 3));

            Console.WriteLine("\n--- Проверка чисел на простоту ---");
            // создаем массив целых чисел
            int[] numbersToCheck = { 1, 2, 3, 4, 17, 25, 97 };
            // проходимся по массиву проверяем числа
            foreach (int num in numbersToCheck)
            {
                bool isPrime = Calculator.Prime(num);
                Console.WriteLine($"Число {num} является простым? -> {isPrime}");
            }
            Console.WriteLine(Calculator.Factorial(5));

            try
            {

                Calculator.Divide(6, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine(Calculator.Power(10, 3));
            double x1 = 0, x2 = 0;
            Console.WriteLine(Calculator.SolveQuadratic(1, -3, 2, out x1, out x2));
            Console.WriteLine($"{x1}, {x2}");
        }
    }
}
