// Напишите программу, которая на вход принимает два числа и проверяет,
// являетcя ли первое число квадраом второго
Console.WriteLine("Write a number 1: ");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number 2: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}