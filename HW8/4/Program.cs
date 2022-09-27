// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

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



