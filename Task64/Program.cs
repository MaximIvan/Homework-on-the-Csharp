// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {x} -> ");
Numbers(x);

int Numbers(int Num)
{
    if (Num == 0) return Num;
    Console.Write($"{Num}, ");
    return Numbers(Num - 1);   
}

// Способ решения через void:
// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не нат.число");
//     if (number == 0) return; - хоть и void, но return нужен!!!!
//     Console.Write(number);
//     NumberCounter(number - 1);
// }
// NumberCounter(x);
