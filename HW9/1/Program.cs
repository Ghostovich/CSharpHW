// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int fun (int n)
{
    if (n==0)
    {
        return 0;
    }
    int sum = n+fun(n-1);
        return sum;
    


}


string show(int n)
{
    if (n==1)
    {
        return "1";
    }
    string result = show(n-1)+" "+ n;
    return result;
}

write vvedite num
n = convert  