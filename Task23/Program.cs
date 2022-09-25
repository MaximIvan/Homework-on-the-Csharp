// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int x = new Random().Next(1, 10);
Console.Write($"{x} -> ");
for (int currentX = 1; currentX <= x; currentX++)
    Console.Write($"{Math.Pow(currentX, 3)}, ");
