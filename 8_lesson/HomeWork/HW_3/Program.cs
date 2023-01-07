// 3. Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

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

int[,] Matrix(int[,] first_arr, int[,] second_arr)
{
    int row_size = first_arr.GetLength(0);
    int column_size = first_arr.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if(column_size != second_arr.GetLength(0)) return pr_matrix;
    else if (column_size == second_arr.GetLength(0))
            pr_matrix = new int[row_size, row_size];

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < row_size; j++)
        {
            for(int z = 0; z < column_size; z++)
                pr_matrix[i, j] += first_arr[i, z] * second_arr[z, j];
        }
    }
    return pr_matrix;
}

Console.Write("Row: ");
int row1 = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column1 = int.Parse(Console.ReadLine());

int[,] array1 = MassNums(row1, column1,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array1);

Console.Write("Row: ");
int row2 = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column2 = int.Parse(Console.ReadLine());

int[,] array2 = MassNums(row2, column2,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array2);

Print(Matrix(array1, array2));



