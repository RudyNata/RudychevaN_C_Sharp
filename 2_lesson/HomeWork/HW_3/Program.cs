// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void SecondNumber(int num)
{
    if(num < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }
    
    while(num > 999) num /=10;
    Console.WriteLine(num % 10); 
}

Console.Write("Введите число: ");
SecondNumber(int.Parse(Console.ReadLine()));