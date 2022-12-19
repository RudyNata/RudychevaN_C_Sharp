string Program2(int num1,int num2)
{
    if(num1 % num2 == 0)
        return "Кратно";
    else
        return $"{num1 % num2}";
}
Console.WriteLine("Write number 1: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Write number 2: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(Program2(first, second));
