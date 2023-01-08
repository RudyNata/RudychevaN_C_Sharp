// 1. Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void Number(int m, int n)
{
    if (n < m) return;
        if(m % 2 == 0) Console.Write($"{m}, ");
    Number(m + 1, n);
}

Console.WriteLine("Write numbers from to: ");
Number(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));