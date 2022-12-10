// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
string Num = Console.ReadLine();
int N = int.Parse(Num);

    
if(N % 2 == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");