// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int x = int.Parse(Console.ReadLine()); 
char[] arr = x.ToString().ToCharArray();

int x1 = arr[0];
int x2 = arr[1];
int x4 = arr[3];
int x5 = arr[4];
if (x1==x5 && x2==x4) {
    Console.WriteLine("Это палиндром");
}
else Console.WriteLine("Это не палиндром");


