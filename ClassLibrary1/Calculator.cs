using System;

namespace MathLib
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            ValidateDouble(a, nameof(a));
            ValidateDouble(b, nameof(b));

            if (b == 0)
            {
                throw new DivideByZeroException("Parameter 'b' cannot be zero in division.");
            }

            return a / b;
        }

        public static bool Prime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static double Power(double baseNum, double exponent)
        {
            ValidateDouble(baseNum, nameof(baseNum));
            ValidateDouble(exponent, nameof(exponent));

            return Math.Pow(baseNum, exponent);
        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(n),
                    n,
                    "Factorial is defined only for non-negative integers."
                );
            }

            if (n > 12) 
            {
                throw new OverflowException(
                    "Factorial result exceeds the maximum value for Int32."
                );
            }

            if (n == 0 || n == 1)
                return 1;

            int result = 1;

            checked
            {
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
            }

            return result;
        }

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
            {
                throw new ArgumentException(
                    "Coefficient 'a' cannot be zero in a quadratic equation.",
                    nameof(a)
                );
            }

            double discriminant = b * b - 4 * a * c;

            if (double.IsNaN(discriminant) || double.IsInfinity(discriminant))
            {
                throw new ArithmeticException(
                    "Invalid discriminant value calculated."
                );
            }

            if (discriminant < 0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
                return false;
            }

            double sqrtD = Math.Sqrt(discriminant);

            x1 = (-b + sqrtD) / (2 * a);
            x2 = (-b - sqrtD) / (2 * a);

            return true;
        }

        // Общая проверка double
        private static void ValidateDouble(double value, string paramName)
        {
            if (double.IsNaN(value))
                throw new ArgumentException("Value cannot be NaN.", paramName);

            if (double.IsInfinity(value))
                throw new ArgumentException("Value cannot be Infinity.", paramName);
        }
    }
}