// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int Number(int m, int n)
{
    if (n < m) return 0;
    return Number(m + 1, n) + m;
}

Console.WriteLine("Write numbers from to: ");
Console.WriteLine(Number(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine())));