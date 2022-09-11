// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите цифру:");
int n = int.Parse(Console.ReadLine()); 
int i=1;
while (i<=n) {
   int res=i*i*i;
   i++;
   Console.Write($"{res} ");
}

