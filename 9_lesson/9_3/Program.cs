// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int Number(int n)
{
    if(n == 0) return 0;
    return Number(n / 10) + n % 10;
}

Console.Write("Number: ");
Console.WriteLine(Number(int.Parse(Console.ReadLine())));
