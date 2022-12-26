// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

void PrintArray(int[] collection)
{
    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]}, "); 
    }
    Console.WriteLine();
}

int[] FillArray(int massiv, int from, int to)
{
    int[] array = new int[massiv];
    for (int index = 0; index < massiv; index++)
    {
        array[index] = new Random().Next(from, to + 1);
    }
    return array;
}

void Summa(int[] numbers)
 {
   int PositivSum = 0;
   int NegativSum = 0;
   for (int i = 0; i < numbers.Length; i++)
    {
      if(numbers[i] > 0)
         PositivSum = PositivSum + numbers[i];
     else
         NegativSum = NegativSum + numbers[i];
    }
Console.WriteLine($"{PositivSum}, {NegativSum}");
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Summa(arr_1);

