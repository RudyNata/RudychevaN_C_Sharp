// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string SecondNumber(int num)
{
    if((num > 99)&(num < 999))
        return $"{num % 10}";
        if(num < 100)
            return "третьей цифры нет";
    else
        return "Не трехзначное";
}

Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SecondNumber(number));