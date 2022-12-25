// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

int NumOfDigits(int num)
{
   int number = 1;
    for(int i = 1; num > 0; i++)
     {
        num = num / 10;
        number = i;
     }
   return number;
}

Console.WriteLine(NumOfDigits(int.Parse(Console.ReadLine())));
