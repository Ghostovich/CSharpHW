// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray ()
{
    int[] array = new int[8];

       for (int i=0; i<array.Length; i++)
       {
        array[i] = new Random().Next(0,2);
       } 

return array;
}

void PrintArrayToConsole (int[] array)
{
          for (int i=0; i<=array.Length; i++)
       {
        Console.WriteLine(array[i]);
       } 
}

int[] array = GetArray();
PrintArrayToConsole(array);
