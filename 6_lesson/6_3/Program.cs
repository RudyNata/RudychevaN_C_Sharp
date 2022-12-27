// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

void Fibonacci(int num)
{
    int fib_num1 = 0, fib_num2 = 1;

    for (int i = 0; i <= num; i++)
    {
        Console.Write($"{fib_num1}");
        (fib_num1, fib_num2) = (fib_num2, fib_num1 + fib_num2);
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Fibonacci(number);
