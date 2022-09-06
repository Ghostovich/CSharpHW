// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите числа:");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a>b) {
    if (a>c){
    Console.Write($"Максимальное число {a}");
    }
    else if (c>a) {
        Console.Write($"Максимальное число {c}");
    }
}

else if (a<b) {
    if (b>c){
    Console.Write($"Максимальное число {b}");
    }
    else if (c>b) {
        Console.Write($"Максимальное число {c}");
    }
}

    
