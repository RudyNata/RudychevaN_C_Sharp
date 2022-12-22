//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void SquareNumber(int N)
{
    int i = 0;
    while(i <= N)
    {
        double SqrN = Math.Pow(i, 2);
        i++;
        Console.Write($"{SqrN}, ");
    }
    
}

SquareNumber(int.Parse(Console.ReadLine()));