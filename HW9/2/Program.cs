// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetArray(int m, int n)
{
    if (n==m)
    return m;

    int sum= n+GetArray(m,n-1);
    return sum;
}

string Show (int m, int n)
{
    if (n==m)
    {
        return $"{m}";
    }
    string result = Show(m,n-1)+ " " +n;
    return result;
}

writeline vvedite num
n = convert





