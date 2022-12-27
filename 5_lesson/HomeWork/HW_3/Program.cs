// 3. Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

void PrintArray(double[] collection)
{
    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]}, ");
    }
    Console.WriteLine();
}

double[] FillArray(int massiv, int from, int to)
{
    double[] arr = new double[massiv];
    Random n_new = new Random();
    for (int index = 0; index < massiv; index++)
    {
        arr[index] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    }
    return arr;
}

double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }

    double difference = max - min;
    return difference;

}

double[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                                int.Parse(Console.ReadLine()),
                                int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Diff(arr_1));
