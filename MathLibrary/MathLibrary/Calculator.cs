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
        public static long Factorial(int n) //вычисление факториала, обработка исключений дополнительная
        {
            if (n < 0)
                throw new ArgumentException($"Факториал не определен для отрицательных чисел: {n}");

            if (n > 20)
                throw new ArgumentException($"Факториал {n} слишком велик для типа long");

            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool SolveQuadratic(double a, double b, double c, out double? x1, out double? x2) 
            //решение квадратного уравнения, обработка исключений дополнительная
        {
            x1 = null;
            x2 = null;

            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
                throw new ArgumentException("Коэффициенты не могут быть NaN");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        throw new ArgumentException("Уравнение 0 = 0 имеет бесконечное число решений");
                    return false;
                }

                x1 = -c / b;
                return true;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return false;
            }

            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            x1 = (-b + sqrtDiscriminant) / (2 * a);
            x2 = (-b - sqrtDiscriminant) / (2 * a);
            return true;
        }
        /// <summary>
        /// Вычисление площади круга по радиусу
        /// </summary>
        public static double CircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Конвертация градусов Цельсия в Фаренгейт
        /// </summary>
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Конвертация градусов Фаренгейта в Цельсий
        /// </summary>
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Расчет гипотенузы прямоугольного треугольника по двум катетам
        /// </summary>
        public static double Hypotenuse(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException("Длины катетов не могут быть отрицательными");

            return Math.Sqrt(a * a + b * b);
        }
    }
}