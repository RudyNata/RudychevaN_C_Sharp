// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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

int[,] RegArr(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        int max_num = arr[i, 0];
        for (int j = 0; j < column_size; j++)
        {
            for(int z = j + 1; z < column_size; z++)
            {
                if(arr[i, z] > max_num)
                    {
                        max_num = arr[i, z];
                    }
            (arr[i, j], max_num) = (max_num, arr[i, j]);
            }
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
RegArr(array);
Print(array);