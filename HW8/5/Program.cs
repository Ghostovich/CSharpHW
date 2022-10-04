// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4;
int n = 4;

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    int k = 1, t = 0, i, j = 0, m1 = m, n1 = n;

    while (k <= m1 * n1)
    {
        for (i = t; i < m; i++)
            array[j, i] = k++;
        j = m - 1;
        for (i = t + 1; i < n; i++)
            array[i, j] = k++;
        j = n - 1;
        for (i = m - 2; i >= t; i--)
            array[j, i] = k++;
        j = t;
        for (i = n - 2; i > t; i--)
            array[i, j] = k++;
        m--;
        n--;
        t++;
        j = t;
    }

    return array;
}

int[,] print = GetArray(m, n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,2} ", print[i, j]);
    }
    Console.WriteLine();
}


