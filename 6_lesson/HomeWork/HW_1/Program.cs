// 1. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Не получилось сделать, чтобы пользователь вводил сколько угодно чисел:
// int Num()
// {
//     int count = 0;
//     int user_num = int.Parse(Console.ReadLine());
//     if(user_num != null)
//     {
//         int some_num = int.Parse(Console.ReadLine());
//         if(some_num > 0)
//             count++;
//     }
//     return count;
// }

// Получилось только для запроса кол-ва вводимых чисел:
int Num(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        int some_num = int.Parse(Console.ReadLine());
        if (some_num > 0)
            count++;
    }
    return count;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Num(n));
