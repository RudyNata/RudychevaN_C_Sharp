// Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}

int[,] SquareMass(int[,] arr)
{
    int rownew_size = arr.GetLength(0);
    int columnnew_size = arr.GetLength(1);

    for (int i = 1; i < rownew_size; i += 2)
    {
        for (int j = 1; j < columnnew_size; j += 2)
        {
                arr[i, j] = arr[i,j] * arr[i,j];
        }
    }
    return arr;
}

Console.Write("Row: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column = int.Parse(Console.ReadLine());

int[,] array = MassNums(row, column,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array);
SquareMass(array);
Print(array);
