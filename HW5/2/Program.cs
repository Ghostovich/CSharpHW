// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray() {
    int[] array = new int[4];
    for (int i = 0; i<array.Length; i++)
    {
    array[i] = new Random().Next(-100,100);
    }
    return array;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if(i%2==1)
        {
            sum +=array[i];
        }
    }
    return sum;
}

int[] printArray = GetArray();
Console.WriteLine(string.Join(",", printArray));
int printSum = Sum(printArray);
Console.WriteLine(printSum);





