// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetPoint(double b1, double k1, double b2, double k2)
{
double x = -(b1-b2)/(k1-k2); 
double y = k2 * x + b2;
double[] point = new double[2] {x,y};
return point;
}

Console.Write("Введите b1:");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = double.Parse(Console.ReadLine());

double[] point = GetPoint(b1, k1, b2, k2);
try
{
Console.Write("Координаты точки пересечения прямых:");
Console.WriteLine(string.Join(", ", point));
}
catch
{
    Console.Write("Прямые не пересекаются!");
}