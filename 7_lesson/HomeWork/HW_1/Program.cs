// 1. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i,j], 6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().NextDouble() * to;
    }
    return arr;
}

Console.Write("Row: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column = int.Parse(Console.ReadLine());

double[,] array = MassNums(row, column, 
                            double.Parse(Console.ReadLine()),
                            double.Parse(Console.ReadLine()));
Print(array);
