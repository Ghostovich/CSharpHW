// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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



