// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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
        array[index] = new Random().Next(0, 11);
    }
    return array;
}

int[] NewArray(int[] newarray)
{
    int size = newarray.Length;
    int new_size = size / 2 + size % 2;
    int[] new_arr = new int[new_size];

    for (int i = 0; i < size / 2; i++)
        new_arr[i] = newarray[i] * newarray[size - i - 1];
    if(new_arr[new_size - 1] == 0)
        new_arr[new_size - 1] = newarray [new_size - 1];
    return new_arr;
}

int[] arr_1 = FillArray(5);
PrintArray(arr_1);
int[] arr_1_new = NewArray(arr_1);
PrintArray(arr_1_new);
