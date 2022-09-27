// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = new Random().Next(3,5);
int n = new Random().Next(3,5);

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

