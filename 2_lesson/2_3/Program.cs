//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

string Crat(int num)
{
    if((num % 7 == 0)&(num % 23 == 0))
        return "Кратно обоим числам";
    else
        return "Не кратно";
}

Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(Crat(number));