// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
string Num1 = Console.ReadLine();
int N1 = int.Parse(Num1);

Console.WriteLine("Введите число 2: ");
string Num2 = Console.ReadLine();
int N2 = int.Parse(Num2);

if(N1 > N2)
    Console.WriteLine(N1);
else
   Console.WriteLine(N2); 