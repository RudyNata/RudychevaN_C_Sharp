// 3. Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void FillArray(int[] massiv)
{
    int length = massiv.Length;
    for (int index = 0; index < length; index++)
    {
        massiv[index] = new Random().Next(100);
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]}, ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);


