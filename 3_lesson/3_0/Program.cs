// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(int x, int y)
{
    if(x == 0 || y == 0)
        Console.WriteLine("x = 0, pr y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("1 quarter");
    else if (x < 0 && y > 0)
        Console.WriteLine("2 quarter");
    else if (x < 0 && y < 0)
        Console.WriteLine("3 quarter");
    else if (x > 0 && y < 0)
        Console.WriteLine("4 quarter"); 
}

Console.WriteLine("Ввудите координату х: ");
int numberX = int.Parse(Console.ReadLine());

Console.WriteLine("Ввудите координату y: ");
int numberY = int.Parse(Console.ReadLine());

Quarters(numberX, numberY);