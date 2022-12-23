// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumber(int N)
{
    for(int i = 1; i <= N; i++)
    {
        double CubeNum = Math.Pow(i, 3);
        Console.Write($"{CubeNum}, ");
    }   
}

CubeNumber(int.Parse(Console.ReadLine()));