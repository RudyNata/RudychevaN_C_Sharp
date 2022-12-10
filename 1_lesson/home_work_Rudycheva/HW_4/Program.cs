// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");

string Num = Console.ReadLine();
int N = int.Parse(Num);
int N1 = 0;

while(N1 <= N)
{
    Console.Write(N1);
N1 += 2;
}
