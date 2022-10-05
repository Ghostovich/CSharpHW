// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;

int[,] GetArray1(int m, int n)
{
    int[,] array1 = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array1[i, j] = new Random().Next(1, 10);
        }
    }
    return array1;
}

int[,] GetArray2(int m, int n)
{
    int[,] array2 = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array2[i, j] = new Random().Next(1, 10);
        }
    }
    return array2;
}

int[,] GetNew(int[,] arr1, int[,] arr2, int m, int n)
{
    int[,] arr3 = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}

int[,] arr1 = GetArray1(m, n);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] arr2 = GetArray2(m, n);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] arrN = GetNew(arr1, arr2, m, n);
Console.WriteLine($"Результирующая матрица: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arrN[i, j] + " ");
    }
    Console.WriteLine();
}



