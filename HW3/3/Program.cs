// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double f (int n) {
for (int i = 0; i<=n; i++)
{
double res = Math.Pow(i, 3);
return res;
}
 
}

Console.Write("Введите цифру:");
int n = int.Parse(Console.ReadLine()); 

double res = f(n); 
Console.Write(res);

