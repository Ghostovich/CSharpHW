// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
