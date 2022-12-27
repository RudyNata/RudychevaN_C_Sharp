// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

void PrintArray(int[,] collection)
{
    int raw = collection.GetLength(0);
    int stolb = collection.GetLength(1);

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < stolb; j++)
            Console.Write($"{collection[i,j]}, ");
        Console.WriteLine();
    }
}

int[,] FillArray(int raw, int stolb)
{
    int[,] array = new int[raw, stolb];
    for (int i = 0; i < raw; i++)
        for (int j = 0; j < stolb; j++)
            array[i,j] = new Random().Next(-100, 100);
    return array;
}

int[,] arr_1 = FillArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
PrintArray(arr_1);