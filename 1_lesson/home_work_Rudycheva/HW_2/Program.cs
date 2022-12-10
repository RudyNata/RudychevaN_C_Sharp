// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1: ");
string Num1 = Console.ReadLine();
int N1 = int.Parse(Num1);

Console.WriteLine("Введите число 2: ");
string Num2 = Console.ReadLine();
int N2 = int.Parse(Num2);

Console.WriteLine("Введите число 3: ");
string Num3 = Console.ReadLine();
int N3 = int.Parse(Num3);
    
if(N1 > N2 && N1 > N3)
    Console.WriteLine(N1);
else if (N2 > N1 && N2 > N3)
    Console.WriteLine(N2);
else
    Console.WriteLine(N3);
