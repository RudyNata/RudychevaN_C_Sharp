// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summ(int num)
{
    int Summa = 0;
    for(int i = 1; num > 0; i++)
     {
        Summa = Summa + num % 10;
        num = num / 10;
     }
     return Summa;
}

Console.Write("Write a number: ");
Console.WriteLine(Summ(int.Parse(Console.ReadLine())));