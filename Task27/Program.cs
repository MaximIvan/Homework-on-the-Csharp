// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int N = new Random().Next(1, 100000);
N = 9012;
Console.Write($"{N} -> ");
int sum = 0;
int ost = 0;
while (N != 0)
{
    ost = N % 10;
    sum = sum + ost;
    N = N / 10;
}
Console.Write(sum);
