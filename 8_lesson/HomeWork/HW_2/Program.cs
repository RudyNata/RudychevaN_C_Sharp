// 2. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

void Min(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int small = 0;
    for (int i = 0; i < row_size; i++)
    {
        int sum = 0;
        for (int j = 0; j < column_size; j++)
        {
            sum = sum + arr[i,j];
        }
        if(sum > small)
            small = i;
    }
    Console.WriteLine();
    Console.WriteLine($"Smallest: {small + 1}");
}

Console.Write("Row: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column = int.Parse(Console.ReadLine());

int[,] array = MassNums(row, column,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array);
Min(array);