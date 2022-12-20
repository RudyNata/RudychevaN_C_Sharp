// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int RandomNum(int num)
{
 Console.WriteLine(num);
 return ((num / 100) * 10) + (num % 10);
}

Console.WriteLine(RandomNum(new Random().Next(100, 1000)));