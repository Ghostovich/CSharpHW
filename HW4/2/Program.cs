// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int a)
{
    int[] arr = a.ToString().ToCharArray().Select(b => b - '0').ToArray();
    int s = arr.Length;
    int sum = 0;
   for (int i = 0; i < s; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());

int sum = GetSum(a);
Console.Write(sum);







