// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины

void CanTriagle(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 
        && num2 < num1 + num3
        && num3 < num1 + num2)
        Console.WriteLine("Треугольник возможен");
    else
        Console.WriteLine("Треугольник невозможен");
}

Console.Write("Введите длинну 1ой стороны: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите длинну 2ой стороны: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите длинну 3ей стороны: ");
int number3 = int.Parse(Console.ReadLine());

CanTriagle(number1, number2, number3);
