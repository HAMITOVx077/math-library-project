# MathLibrary - Математическая библиотека на C#

Библиотека предоставляет основные математические функции:

## Основные методы:
- `Add(a, b)` - сложение
- `Subtract(a, b)` - вычитание  
- `Multiply(a, b)` - умножение
- `Divide(a, b)` - деление
- `IsPrime(n)` - проверка на простое число

## Расширенные методы:
- `Power(number, power)` - возведение в степень
- `Factorial(n)` - вычисление факториала
- `SolveQuadratic(a, b, c)` - решение квадратного уравнения

## Пример использования:
```csharp
double result = Calculator.Add(5, 3); // 8
bool isPrime = Calculator.IsPrime(7); // true