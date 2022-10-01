// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = new Random().Next(10001, 100000);

int Num1 = num / 10000;
int a = num / 1000;
int Num2 = a % 10;
int b = num % 100;
int Num4 = b / 10;
int Num5 = num % 10;

if ((Num1 == Num5) && (Num2 == Num4)) Console.Write($"{num} -> является палиндромом");
else Console.Write($"{num} -> не является палиндромом");

// чужое решение через массив:
// int[] array = new int[5];
// Console.Write("Введите пятизначное число ");
// int num = Int32.Parse(Console.ReadLine());

// if (num > 1000 || num < 99999) Console.Write("Вы ввели неверное число");
// for(int i = 0; i < 5; i++)
// {
//      array[i] = num % 10;
//      num = num / 10;
// }
// if(array[1] == array[3] & array[0] == array[4]) Console.Write("Введенное число является палиндромом");
// else Console.Write ("Введенное число не является палиндромом");

// УНИВЕРСАЛЬНЫЙ СПОСОБ (развернуть число):
// int[] array = new int[5];
// Console.Write("Введите пятизначное число ");
// int num = Int32.Parse(Console.ReadLine());
// int rev = 0;
// 
// while (num > 0)
// {
//      rev = rev *10 + num % 10;
//      num = num / 10;
// }
// if(rev == num) Console.Write("Введенное число является палиндромом");
// else Console.Write ("Введенное число не является палиндромом");
