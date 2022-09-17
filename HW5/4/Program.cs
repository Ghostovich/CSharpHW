// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray() 
{
    double[] array = new double[5];
    for (int i = 0; i<array.Length; i++)
    {
       array[i] = new Random().Next(-100,100)/10.0;
    }
    return array;
}

double Diff(double[] array)
 {
   double max = array[0];
   double min = array[0];
   for(int i = 1; i<array.Length; i++)
   {  
      if (array[i]>max)
      {
         max = array[i];
      }
   }
   for(int i = 1; i<array.Length; i++)
   {  
      if (array[i]<min)
      {
         min = array[i];
      }
   }
   double diff = max - min;
   return diff;
 }

double[] printArray = GetArray();
Console.WriteLine(string.Join(", ", printArray));
double printDiff = Diff(printArray);
Console.WriteLine(printDiff);


