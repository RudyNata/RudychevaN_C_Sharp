// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Polindrom (int Num)
{
    if(Num < 10000 || Num > 99999)
        return "Not a five digit number";
    else if(Num / 10000 == Num % 10 && (Num / 1000) % 10 == (Num / 10) % 10)
        return "Number is polindrom";
    else
        return "Number isn't polindrom";
}

Console.WriteLine(Polindrom(int.Parse(Console.ReadLine())));
