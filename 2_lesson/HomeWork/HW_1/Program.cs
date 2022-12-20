// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string SecondNum(int num)
{
    if((num > 99)&(num < 999))
        return $"{(num / 10) % 10}";
    else
        return "Не трехзначное число";
}

Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SecondNum(number));