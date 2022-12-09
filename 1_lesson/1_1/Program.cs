// a=25, b=5
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