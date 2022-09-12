// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string GetMas(string a)
{
    string mas = $"[{a}]";
    return mas;
}

Console.Write("Введите массив из 8 чисел:");
string a = Console.ReadLine();

string mas = GetMas(a);
Console.Write(mas);