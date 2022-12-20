// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string SecondNumber(int num)
{
    if(num > 99) 
        int num = ToString();
        return $"{num[3]}";
    else
        return "Третьей цифры нет";
}

Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SecondNumber(number));