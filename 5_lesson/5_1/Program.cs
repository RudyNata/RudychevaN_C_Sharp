// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.

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
        array[index] = new Random().Next(-100, 100);
    }
    return array;
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
ChangeArray(arr_1);
PrintArray(arr_1);