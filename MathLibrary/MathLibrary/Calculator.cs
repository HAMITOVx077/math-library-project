using System;

namespace MathLibrary
{
    /// <summary>
    /// Основной класс математической библиотеки.
    /// Содержит методы для базовых арифметических операций и проверки чисел.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Складывает два числа.
        /// </summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитает второе число из первого.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножает два числа.
        /// </summary>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Делит первое число на второе.
        /// </summary>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делитель не может быть равен нулю.");
            }
            return a / b;
        }

        /// <summary>
        /// Проверяет, является ли число простым.
        /// </summary>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Возведение числа в степень.
        /// </summary>
        public static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }

        /// <summary>
        /// Вычисление факториала числа.
        /// </summary>
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Решение квадратного уравнения.
        /// </summary>
        /// <returns>true - если есть действительные корни, false - в противном случае</returns>
        public static bool SolveQuadratic(double a, double b, double c, out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;

            if (a == 0)
            {
                //это линейное уравнение, а не квадратное
                if (b != 0)
                {
                    x1 = -c / b;
                    return true;
                }
                return false;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return false; //нет действительных корней
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
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