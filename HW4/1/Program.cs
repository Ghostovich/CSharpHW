// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetExp(int a, int b)
{
    double c = Math.Pow(a, b);
    int exp;
    exp = (int)c;
    return exp;
}

Console.Write("Введите число А:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число В:");
int b = int.Parse(Console.ReadLine());

int exp = GetExp(a, b);
Console.Write(exp);
