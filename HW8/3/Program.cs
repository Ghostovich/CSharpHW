// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = new Random().Next(1,10);
int n = new Random().Next(1,10);

int[,] GetArray (int n, int m)
{
    int[,] array = new int[n, m];
    for (int i=0; i<n;i++)
    {
        for (int j=0; j<m; j++)
        {
           array [i,j] = new Random().Next(-10,10);
        }
    }
    return array;
}

Console.WriteLine("Введите значение столбца:");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение строки:");
int j = int.Parse(Console.ReadLine());

int[,] arr = GetArray(n,m);
for (int k=0; k<n; k++)
{
    for (int l=0; l<m; l++)
    {
        Console.Write(arr [k,l]+" ");
    }
    Console.WriteLine();
}
try
{
    Console.WriteLine($"Значение заданного элемента равно {arr[i,j]}");
}
catch
{
    Console.WriteLine("Такого значения нет!");
}



