// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

double Distance(double x1, double y1, double x2, double y2)
{
    double Dist;
    Dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Dist;
}

Console.Write("Введите координату х1: ");
double CoordX1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату y1: ");
double CoordY1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату х2: ");
double CoordX2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату y2: ");
double CoordY2 = double.Parse(Console.ReadLine());

Console.WriteLine(Distance(CoordX1, CoordY1, CoordX2, CoordY2));