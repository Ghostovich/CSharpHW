// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4;
int n = 4;

int[,] GetArray(int m, int n)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

int[] GetNew(int[,] arr, int m, int n)
{
    int[] arrayN = new int[4];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arrayN[i] += arr[i, j];
        }
    }
    return arrayN;
}

int GetMin(int[] arrN)
{
    int j = 0;
    int min = arrN[0];
    for (int i = 0; i < arrN.Length; i++)
    {
        if (arrN[i] < min)
        {
            min = arrN[i];
            j = i;
        }
    }
    return j;
}

int[,] arr = GetArray(m, n);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] arrN = GetNew(arr, m, n);

int minS = GetMin(arrN);
Console.Write($"{minS + 1} строка");



