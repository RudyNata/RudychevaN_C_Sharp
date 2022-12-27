// 1.  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.

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
        arr[index] = new Random().Next(100, 1000);
    }
    return arr;
}

string EvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;

    }
    return $"{count}";
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(EvenNum(arr_1));