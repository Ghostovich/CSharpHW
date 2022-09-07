// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());
char[] arr = a.ToString().ToCharArray();
int b = arr.Length;
if (b<3) {
Console.Write("Третьей цифры нет");
}
else if (b>=3)
{
Console.Write(arr[2]);
}