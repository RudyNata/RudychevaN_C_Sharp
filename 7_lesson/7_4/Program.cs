// Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет

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

string Search(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int some_num = int.Parse(Console.ReadLine());
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            if (arr[i, j] == some_num)
                return $"[{i + 1}, {j + 1}]";
    }
    return "No number";
}

Console.Write("Row: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Column: ");
int column = int.Parse(Console.ReadLine());

int[,] array = MassNums(row, column,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Print(array);
Console.WriteLine((Search(array)));