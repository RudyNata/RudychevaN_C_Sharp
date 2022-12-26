// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int num, int step)
{
    int Product = 1;
    for (int i = 1; i <= step; i++)
    {
        Product = Product * num;
    }
    return Product;
}

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Stepen(num: num1, step: num2));
