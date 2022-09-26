// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int m = new Random().Next(3,5);
// int n = new Random().Next(3,5);

int m = 3;
int n = 4;

int[,] GetArray (int n, int m)
{
    int[,] array = new int[m, n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
           array [i,j] = new Random().Next(-10,10);
        }
    }
    return array;
}

double[] GetMiddle(int[,] arr, int n, int m)
{   
    double[] mid = new double[n];
    int sum = 0;
    for (int j=0; j<n; j++)
    {
        for (int i=0; i<m; i++)
        {
            sum = sum+arr[i,j];
        }
        mid[j] = (double)sum/m;
        mid[j] = Math.Round(mid[j],1);
        sum = 0;
    }   
    return mid;
}

int[,] arr = GetArray(n,m);
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        Console.Write(arr [i,j]+" ");
    }
    Console.WriteLine();
}
double[] printMid = GetMiddle(arr, n, m);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
Console.Write(string.Join(" ", printMid));

