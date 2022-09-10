// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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


