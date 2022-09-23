// Написать программу, которая принимает на вход 3-х значное число и на 
// выходе показывает вторую цифру этого числа.

// 456 - 5
// 782 - 8
// 918 - 1

int num = new Random().Next(100, 999);
int numOst = num % 100;
int secondNum = numOst / 10;
Console.Write($"{num} - {secondNum}");