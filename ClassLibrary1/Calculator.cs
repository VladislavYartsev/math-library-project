using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MathLib
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public static bool Prime(int number)
        {
            if (number <= 1) { return false; }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool SolveQuadratic(double a, double b, double c, out double x1, out double x2)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
                return false;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return true;
            }

        }
    }
}
