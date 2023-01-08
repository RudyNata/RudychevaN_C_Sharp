// Задайте значения M и N. Напишите программу, которая рекурсивно
// выведет все натуральные числа в промежутке от M до N

void Number(int m, int n)
{
    if (n < m) return;
    Console.Write($"{m}, ");
    Number(m + 1, n);
}

Console.WriteLine("Write numbers from to: ");
Number(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));