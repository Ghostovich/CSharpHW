// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int countZero(int[] arr)
{
    int s = arr.Length;
    int count = 0;
    for (int i = 0; i < s; i++)
    {
         if (arr[i]>0)
        {
            count+=1;
        }
    }
    return count;
}

Console.WriteLine("Введите количество чисел:");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите число:");
    arr[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
    i++;
}
for (i = 0; i < n; i = i + 1)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int array = countZero(arr);
Console.WriteLine($"Количество положительных чисел: {array}");