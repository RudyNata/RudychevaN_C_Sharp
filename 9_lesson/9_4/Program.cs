// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Number(int a, int b)
{
    if(b <= 0) return 1;
    return Number(a, b-1) * a;
}

Console.WriteLine("Numbers: ");
Console.WriteLine(Number(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

