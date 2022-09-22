// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray() {
    int[] array = new int[4];
    for (int i = 0; i<array.Length; i++)
    {
    array[i] = new Random().Next(99,1000);
    }
    return array;
}

int NumCount(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count +=1;
        }
    }
    return count;
}

int[] printArray = GetArray();
Console.WriteLine(string.Join(",", printArray));
int printCount = NumCount(printArray);
Console.WriteLine(printCount);
