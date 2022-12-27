// 2.  Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int Summ(int[] array)
{
    int Summa = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Summa = Summa + array[i];
    }
    return Summa;
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Summ(arr_1));