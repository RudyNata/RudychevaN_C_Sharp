//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Poli(int[] array)
{
    int count = array.Length;
    array[index] = 0;
    if(count = 5)
        if((array[index] = 0 == array[index] = 4)&(array[index] = 1 == array[index] = 3))
            return "Палиндромом";
        else
            return "Не палиндром"; 
    else
        return "Не пятизначное число";
}

Console.WriteLine("Введите 5-ти значное число: ");
int[] number = int.Parse(Console.ReadLine());

Console.WriteLine(Poli(number));