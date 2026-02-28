using System;
using System.Numerics;

namespace MathLib
{
    /// <summary>
    /// Provides basic mathematical operations.
    /// </summary>
    public static class Calculator
    {

        /// <summary>
        /// Returns the sum of two numbers.
        /// </summary>
        public static double Add(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a + b;
        }

        /// <summary>
        /// Returns the difference between two numbers.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a - b;
        }

        /// <summary>
        /// Returns the product of two numbers.
        /// </summary>
        public static double Multiply(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a * b;
        }

        /// <summary>
        /// Divides a by b.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public static double Divide(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));

            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return a / b;
        }


        /// <summary>
        /// Determines whether a number is prime.
        /// Optimized: checks only up to sqrt(n) and skips even numbers.
        /// </summary>
        public static bool Prime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int limit = (int)Math.Sqrt(number);

            for (int i = 3; i <= limit; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Raises a number to the specified power.
        /// </summary>
        public static double Power(double baseNum, double exponent)
        {
            ValidateDouble(baseNum, nameof(baseNum));
            ValidateDouble(exponent, nameof(exponent));
            return Math.Pow(baseNum, exponent);
        }

        /// <summary>
        /// Computes factorial of a non-negative integer.
        /// Uses checked context to detect overflow.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n),
                    "Factorial is defined only for non-negative integers.");

            if (n > 12) // 13! exceeds Int32
                throw new OverflowException(
                    "Factorial result exceeds Int32 range.");

            int result = 1;

            checked
            {
                for (int i = 2; i <= n; i++)
                    result *= i;
            }

            return result;
        }

        /// <summary>
        /// Solves quadratic equation ax² + bx + c = 0.
        /// Returns true if real roots exist.
        /// </summary>
        public static bool SolveQuadratic(
            double a,
            double b,
            double c,
            out double x1,
            out double x2)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            ValidateDouble(c, nameof(c));

            if (a == 0)
                throw new ArgumentException(
                    "Coefficient 'a' cannot be zero.",
                    nameof(a));

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                x1 = x2 = double.NaN;
                return false;
            }

            double sqrtD = Math.Sqrt(discriminant);
            double denominator = 2 * a;

            x1 = (-b + sqrtD) / denominator;
            x2 = (-b - sqrtD) / denominator;

            return true;
        }



        /// <summary>
        /// Validates double input (not NaN or Infinity).
        /// </summary>
        private static void ValidateDouble(double value, string paramName)
        {
            if (double.IsNaN(value))
                throw new ArgumentException("Value cannot be NaN.", paramName);

            if (double.IsInfinity(value))
                throw new ArgumentException("Value cannot be Infinity.", paramName);
        }

    }
}