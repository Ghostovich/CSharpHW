// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray() 
{
    int s = new Random().Next(4,10);
    int[] array = new int[s];
    for (int i = 0; i<array.Length; i++)
    {
    array[i] = new Random().Next(-100,100);
    }
    return array;
}

int[] Multi(int[] array)
{
   int[] mult = new int[array.Length/2];
   if(array.Length%2==0)
   {
      for (int i = 0; i<array.Length/2; i++)
            {
               mult[i]=array[i]*array[array.Length-1-i];
            }
   }
   
   if(array.Length%2==1)
   {
      for (int i = 0; i<array.Length/2; i++)
            {
               mult[i]=array[i]*array[array.Length-1-i];
               
            }
      int item=array[array.Length/2];
      Array.Resize(ref mult, mult.Length + 1);
      mult[mult.Length - 1] = item;
   }
   return mult;
}

int[] printArray = GetArray();
Console.WriteLine(string.Join(",", printArray));
int[] printMult = Multi(printArray);
Console.WriteLine(string.Join(",", printMult));


