// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 *x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Ответ не сходится, хотя если считать вручную все получается. Непонятно, как x получается 0.
string Uravnenie(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k2 * x + b2;
    return $"({x}, {y})";
}

Console.Write("Введите число 1: ");
int numk1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int numb1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");
int numk2 = int.Parse(Console.ReadLine());

Console.Write("Введите число 4: ");
int numb2 = int.Parse(Console.ReadLine());

Console.WriteLine(Uravnenie(k1: numk1, b1: numb1, k2: numk2, b2: numb2));
