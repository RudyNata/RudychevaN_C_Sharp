// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].

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
    int[] array = new int[massiv];
    for (int index = 0; index < massiv; index++)
    {
        array[index] = new Random().Next(0, 124);
    }
    return array;
}

int Poisk (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Poisk(arr_1));