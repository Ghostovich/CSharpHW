// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int l = 2;

bool SearchElem(int[,,] array, int value, int m, int n, int l)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

int[,,] GetArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool flag = false;
                while (flag != true)
                {
                    flag = false;
                    int temp = new Random().Next(10, 100);
                    if (SearchElem(array, temp, m, n, l))
                    {
                        continue;
                    }
                    else
                    {
                        array[i, j, k] = temp;
                        flag = true;
                    }
                }
            }
        }
    }
    return array;
}

int[,,] arr = GetArray(m, n, l);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < l; k++)
        {
            Console.Write($"{arr[i,j,k]} [{i},{j},{k}] ");
        }
        Console.WriteLine();
    }
}

