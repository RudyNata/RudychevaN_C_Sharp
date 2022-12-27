// 3. Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

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

int Diff(int[] array)
{
    int max = 0;
    int min = 0;

    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }

    int difference = max - min;
    return difference;

}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Diff(arr_1));
