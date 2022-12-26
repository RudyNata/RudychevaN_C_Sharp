//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void SquareNumber(int N)
{
    for(int i = 1; i <= N; i++)
    {
        double SqrN = Math.Pow(i, 2);
        Console.Write($"{SqrN}, ");
    }   
}

SquareNumber(int.Parse(Console.ReadLine()));