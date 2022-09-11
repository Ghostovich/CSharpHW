// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetSum (int a)
{
int number = Math.Abs(a);
char[] arr = number.ToString().ToCharArray();
int sum = arr.Length;
return sum;
}

Console.Write("Введите число:");

try {
int a = int.Parse(Console.ReadLine());


int sum = GetSum(a);
Console.Write(sum);
}

catch (Exception ex){
Console.Write($"Неверный формат. Ошибка: {ex.Message}");  
}