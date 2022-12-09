// Напишите программу вычислени модуля числа
Console.WriteLine("Введите число: ");

string Num = Console.ReadLine();
int N = int.Parse(Num);

if(N < 0)
    Console.WriteLine(N*(-1));
else
   Console.WriteLine(N); 