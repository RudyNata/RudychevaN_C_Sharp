// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Num (int n)
{
    if(n == 0) return;
    Num(n-1);
    Console.Write($"{n}, ");
}

Console.Write("Number: ");
Num(int.Parse(Console.ReadLine()));

