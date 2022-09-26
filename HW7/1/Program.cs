// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = new Random().Next(1,10);
int n = new Random().Next(1,10);

double[,] GetArray (int m, int n)
{   
    double[,] array = new double[n, m];
    for (int i=0; i<n;i++)
    {
        for (int j=0; j<m; j++)
        {
           array [i,j] = new Random().Next(-10,10)/10.0;
        }
    }
    return array;
}

double[,] arr = GetArray(m, n);
for (int i=0; i<n;i++)
{
    for (int j=0; j<m; j++)
    {
        Console.Write(arr [i,j]+" ");
    }
    Console.WriteLine();
}
