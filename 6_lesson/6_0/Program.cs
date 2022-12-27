// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)

void PrintArray(int[] collection)
{
    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]}, ");
    }
    Console.WriteLine();
}

int[] FillArray(int massiv)
{
    int[] arr = new int[massiv];
    for (int index = 0; index < massiv; index++)
    {
        arr[index] = new Random().Next(-100, 100);
    }
    return arr;
}

int[] TurnArray(int[] array)
{
    int Position1 = array[0];
    int Position2 = array[array.Length - 1];

    for (int i = 0; i < array.Length / 2; i++)
    {
        array[i] = Position2;
        array[array.Length - i -1] = Position1;
        Position1 = array[i + 1];
        Position2 = array[array.Length - i - 2];
    }
    return array;
}

// 2-ой вариант решения:
// void RevMas(int[] array)
// {
// int size = array.Length;
//
// for (int i = 0; i < size / 2; i++)
// (array[i], array[size - i - 1]) = (array[size - i - 1], array[i]);
// }

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(TurnArray(arr_1));
PrintArray(arr_1);
