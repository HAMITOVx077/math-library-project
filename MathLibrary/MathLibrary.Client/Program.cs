namespace MathLibrary.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MathLibrary демонстрация работы ===\n");

            //базовые операции
            Console.WriteLine("1. Базовые операции:");
            Console.WriteLine($"200 + 5 = {Calculator.Add(200, 5)}");
            Console.WriteLine($"200 - 5 = {Calculator.Subtract(200, 5)}");
            Console.WriteLine($"200 * 5 = {Calculator.Multiply(200, 5)}");
            Console.WriteLine($"200 / 5 = {Calculator.Divide(200, 5)}");

            //деление на ноль
            Console.WriteLine("\n2. Деление на ноль:");
            try
            {
                Calculator.Divide(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            //простые числа
            Console.WriteLine("\n3. Проверка на простоту:");
            int[] numbers = { 2, 3, 4, 17, 25 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} -> {Calculator.IsPrime(num)}");
            }

            //расширенные функции
            Console.WriteLine("\n4. Расширенные функции:");
            Console.WriteLine($"10^3 = {Calculator.Power(10, 3)}");
            Console.WriteLine($"Факториал 5 = {Calculator.Factorial(5)}");

            //квадратные уравнения
            Console.WriteLine("\n5. Квадратные уравнения:");
            SolveAndPrint(1, -3, 2);
            SolveAndPrint(1, 0, 1);
        }

        static void SolveAndPrint(double a, double b, double c)
        {
            double? x1, x2;
            bool hasRoots = Calculator.SolveQuadratic(a, b, c, out x1, out x2);

            Console.Write($"Уравнение {a}x2 + {b}x + {c} = 0: ");

            if (hasRoots)
            {
                if (x1 == x2)
                    Console.WriteLine($"x = {x1}");
                else
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else
            {
                Console.WriteLine("нет корней");
            }
        }
    }
}