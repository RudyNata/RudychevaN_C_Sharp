// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Binary(int num)
{
    int rem_num = num;
    string binary_num = "";
    while (rem_num > 0)
    {
        binary_num = $"{rem_num % 2}" + binary_num;
        rem_num = rem_num / 2;
    }
    return binary_num; ;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write(Binary(number));

