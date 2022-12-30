// 3. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i,j], 4} ");
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

void Result(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    double res;

    for (int i = 0; i < column_size; i++)
    {
        res = 0;
        for (int j = 0; j < row_size; j++)
            res += arr[j,i];
        Console.WriteLine($"{res/row_size};");
    }
}

Console.Write("Row: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column = int.Parse(Console.ReadLine());

int[,] array = MassNums(row, column, 
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array);
Result(array);
