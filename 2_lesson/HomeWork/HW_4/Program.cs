// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string WeekNumber(int num)
{
    if(num == 1)
        return "Понедельник";
    if(num == 2)
        return "Вторник";
    if(num == 3)
        return "Среда";
    if(num == 4)
        return "Четверг";
    if(num == 5)
        return "Пятница";
    else
        return "Такого дня недели не существует";
}

Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(WeekNumber(number));