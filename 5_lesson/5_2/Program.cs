// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

string WhatNumber (int[] array, int num)
{
    for(int i = 0; i <= array.Length; i++)
    {
        if(array[i] == num)
            return "Число присутствует в массиве";
        break;
    }
    return "Числа в массиве нет";
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(WhatNumber(arr_1, int.Parse(Console.ReadLine())));
