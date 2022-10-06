// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAkkerman (int m, int n)
{
    int result = 0;
    if (m==0)
    {
        result = n+1;
    }
    else if (m>0 && n==0)
    {
        result = GetAkkerman(m-1,1);
    }
    else if (m>0 && n>0)
    {
        result = GetAkkerman(m-1,GetAkkerman(m, n-1));
    }
    return result;
}

Console.WriteLine("Введите значение: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение: ");
int n = int.Parse(Console.ReadLine());

int print = GetAkkerman(m, n);
Console.WriteLine(print);

